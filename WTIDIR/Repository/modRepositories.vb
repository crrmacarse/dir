Imports System.Data.SqlClient

Module modRepositories

    Public Function getRawmatsList(Optional search As String = Nothing, Optional limit As Integer = 0) As List(Of clsRepositoryRawmats)
        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim list As New List(Of clsRepositoryRawmats)
        Dim cItem As clsRepositoryRawmats
        Dim sQuery = "SELECT"
        If limit > 0 Then sQuery &= " Top" & limit
        sQuery &= "
	                    Rawmats.idRawmats,
	                    Rawmats.RSKU,
	                    Rawmats.RSAPCode,
                        Rawmats.RHash,
                        Rawmats.idItemGroup,
	                    ItemGroup.IGName,
	                    Rawmats.RName,
	                    Rawmats.RISPerishable,
	                    Rawmats.RPriority,
                        Rawmats.idBusinessUnit,
	                    BusinessUnit.BUName,
	                    AccountUser.AUFirstName + ' ' + AccountUser.AUMiddleName + ' ' + AccountUser.AULastName AS RAddedBy,
	                    (SELECT AccountUser.AUFirstName + ' ' + AccountUser.AUMiddleName + ' ' + AccountUser.AULastName FROM AccountUser WHERE AccountUser.idAccountUser = Rawmats.RUpdatedBy) AS RUpdatedBy,
	                    Rawmats.RDateCreated,
	                    Rawmats.RDateUpdated,
	                    Rawmats.RStatus

                    FROM Rawmats

                    INNER JOIN AccountUser 
                    ON AccountUser.idAccountUser = Rawmats.RAddedBy
                    INNER JOIN ItemGroup
                    ON ItemGroup.idItemGroup = Rawmats.idItemGroup
                    INNER JOIN BusinessUnit
                    ON BusinessUnit.idBusinessUnit = Rawmats.idBusinessUnit
                       
                    WHERE (Rawmats.RSAPCode LIKE '%'+@search+'%' OR Rawmats.RName LIKE '%'+@search+'%' OR Rawmats.RSKU LIKE '%'+@search+'%')"
        Using oConnect As New SqlConnection(modVariables.sConnectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    oCommand.Parameters.AddWithValue("@search", search)
                    'oCommand.Parameters.AddWithValue("@businessunit", )
                    Using oReader = oCommand.ExecuteReader
                        While oReader.Read
                            cItem = New clsRepositoryRawmats
                            cItem.id = oReader("idRawmats")
                            cItem.sku = oReader("RSKU")
                            cItem.sapcode = oReader("RSAPCode")
                            cItem.hash = oReader("RHash")
                            cItem.idgroup = oReader("idItemGroup")
                            cItem.group = oReader("IGName")
                            cItem.name = oReader("RName")
                            cItem.isperishable = oReader("RISPerishable")
                            cItem.priority = oReader("RPriority")
                            cItem.idbusinessunit = oReader("idBusinessUnit")
                            cItem.businessunit = oReader("BUName")
                            cItem.addedby = oReader("RAddedBy")
                            cItem.updatedby = oReader("RUpdatedBy")
                            cItem.datecreated = oReader("RDateCreated")
                            cItem.dateupdated = oReader("RDateUpdated")
                            cItem.status = oReader("RStatus")
                            list.Add(cItem)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                modGeneral.writeLog(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message, LogState.error)
            End Try
        End Using
        modGeneral.setApplicationState(ApplicationState.Ready)
        Return list
    End Function


    Public Function saveRawmats(clsRawmats As clsRepositoryRawmats) As Boolean
        modGeneral.setApplicationState(ApplicationState.Busy)
        If CInt(modGeneral.executeScalar(sConnectionString, "SELECT Count(idRawmats) FROM Rawmats WHERE idRawmats <>
                                                            @idRawmats AND  RSKU = @rsku AND RName = @rname AND RStatus = 1",
                                                            New clsKeyValuePair("@idRawmats", clsRawmats.id),
                                                            New clsKeyValuePair("@rsku", clsRawmats.sku),
                                                            New clsKeyValuePair("@rname", clsRawmats.name))) > 0 Then
            modGeneral.setApplicationState(ApplicationState.Ready)
            modGeneral.showMessageBox("Rawmats already exisits!", MessageBoxIcon.Hand)
            Return False
        End If
        Dim b As Boolean
        Dim sQuery As String

        If clsRawmats.id > 0 Then

            sQuery = "UPDATE Rawmats Set idItemGroup = @iditemgroup, idBusinessUnit = @idbusinessunit, RSKU = @rsku, 
        RSAPCode = @rsapcode, RHash = @rhash, RName = @rname,RISPerishable = @risperishable, 
        RPriority = @rpriority, RUpdatedBy = @rupdatedby, RDateUpdated = getdate(), RStatus = @rstatus WHERE idRawmats = @idrawmats; SELECT SCOPE_IDENTITY()"

        Else

            sQuery = "INSERT INTO Rawmats(idItemGroup, idBusinessUnit, RSKU, RSapCode, RHash, RName, RISPerishable, RPriority, 
        RAddedBy, RUpdatedBy, RDateCreated, RDateUpdated, RStatus)
        VALUES(@iditemgroup, @idbusinessunit, @rsku, @rsapcode, @rhash, @rname, @risperishable, @rpriority,
                        @raddedby, @rupdatedby, getdate(), getdate(), @rstatus); SELECT IDENT_CURRENT('Rawmats')"

        End If

        Using oConnect As New SqlConnection(sConnectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    With oCommand.Parameters
                        If clsRawmats.id > 0 Then .AddWithValue("@idrawmats", clsRawmats.id)
                        .AddWithValue("@iditemgroup", clsRawmats.idgroup)
                        .AddWithValue("@idbusinessunit", clsRawmats.idbusinessunit)
                        .AddWithValue("@rsku", clsRawmats.sku)
                        .AddWithValue("@rsapcode", clsRawmats.sapcode)
                        .AddWithValue("@rhash", clsRawmats.hash)
                        .AddWithValue("@rname", clsRawmats.name)
                        .AddWithValue("@risperishable", clsRawmats.isperishable)
                        .AddWithValue("@rpriority", clsRawmats.priority)
                        .AddWithValue("@rupdatedby", CurrentAccount.idAccountUser)
                        If Not clsRawmats.id > 0 Then .AddWithValue("@raddedby", CurrentAccount.idAccountUser)
                        .AddWithValue("@rstatus", clsRawmats.status)
                    End With

                    Dim response As Integer = CInt(oCommand.ExecuteScalar())
                    b = response > 0


                    modGeneral.generateSKU(response, clsRawmats.businessunit, clsRawmats.idgroup)
                End Using
            Catch ex As Exception
                modGeneral.writeLog(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message, LogState.error)
            End Try
        End Using
        modGeneral.setApplicationState(ApplicationState.Ready)
        modGeneral.writeLog(System.Reflection.MethodBase.GetCurrentMethod.Name, "success", LogState.msg, False)
        Return b
    End Function


    Public Function getProductItemList(Optional search As String = Nothing, Optional limit As Integer = 0) As List(Of clsRepositoryProduct)
        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim list As New List(Of clsRepositoryProduct)
        Dim cItem As clsRepositoryProduct
        Dim sQuery = "SELECT"
        If limit > 0 Then sQuery &= " Top" & limit
        sQuery &= "
                    ProductItem.idProductItem,
		            ProductItem.PISKU,
		            ProductItem.PIHash,
		            ItemGroup.IGName,
		            ProductItem.PIName,
		            ProductItem.PIBulkDiscount,
		            AccountUser.AUFirstName + ' ' + AccountUser.AUMiddleName + ' ' + AccountUser.AULastName AS PIAddedBy,
		            (
                        SELECT
                            AccountUser.AUFirstName + ' ' + 
                            AccountUser.AUMiddleName + ' ' + 
                            AccountUser.AULastName 
                        WHERE 
                            AccountUser.idAccountUser = ProductItem.PIUpdatedBy
                    ) AS PIUpdatedBy,
		            ProductItem.PIDateCreated,
		            ProductItem.PIDateUpdated,
		            BusinessUnit.BUName,
		            ProductItem.PIPriority,
		            ProductItem.PIStatus


	                FROM ProductItem

	                INNER JOIN AccountUser
	                ON AccountUser.idAccountUser = ProductItem.PIAddedBy
	                INNER JOIN ItemGroup
	                ON ItemGroup.idItemGroup = ProductItem.idItemGroup
	                INNER JOIN BusinessUnit
	                ON ProductItem.idBusinessUnit = BusinessUnit.idBusinessUnit

                    WHERE (ProductItem.PISKU LIKE '%'+@search+'%' OR ProductItem.PIName LIKE '%'+@search+'%')"
        Using oConnect As New SqlConnection(sConnectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    ' Add Paramters for business unit here
                    oCommand.Parameters.AddWithValue("@search", search)
                    Using oReader = oCommand.ExecuteReader
                        While oReader.Read
                            cItem = New clsRepositoryProduct
                            cItem.id = oReader("idProductItem")
                            cItem.sku = oReader("PISKU")
                            cItem.hash = oReader("PIHash")
                            cItem.group = oReader("IGName")
                            cItem.name = oReader("PIName")
                            cItem.bulkdiscount = oReader("PIBulkDiscount")
                            cItem.businessunit = oReader("BUName")
                            cItem.addedby = oReader("PIAddedBy")
                            cItem.updatedby = oReader("PIUpdatedBy")
                            cItem.datecreated = oReader("PIDateCreated")
                            cItem.dateupdated = oReader("PIDateUpdated")
                            cItem.priorty = oReader("PIPriority")
                            cItem.status = oReader("PIStatus")

                            list.Add(cItem)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                modGeneral.writeLog(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message, LogState.error)
            End Try
        End Using
        modGeneral.setApplicationState(ApplicationState.Ready)
        Return list
    End Function


    Public Function getItemGroupList(Optional search As String = "", Optional limit As Integer = 0) As List(Of clsRepositoryItemGroup)
        modGeneral.setApplicationState(ApplicationState.Busy)
        Dim list As New List(Of clsRepositoryItemGroup)
        Dim cItem As clsRepositoryItemGroup
        Dim sQuery = "SELECT"
        If limit > 0 Then sQuery &= " Top" & limit
        sQuery &= "
	                ItemGroup.idItemGroup,
	                ItemGroup.IGSKU,
	                ItemGroup.IGHash,
	                ItemGroup.IGName,
	                ItemGroup.IGType,
	                ItemGroup.IGShortageType,
                    ItemGroup.IGPriority,
	                AccountUser.AUFirstName + ' ' + AccountUser.AUMiddleName + ' ' + AccountUser.AULastName AS IGAddedBy,
	                (
                        SELECT 

                            AccountUser.AUFirstName + ' ' + 
                            AccountUser.AUMIddleName + ' ' + 
                            AccountUser.AULastName 
                    
                        FROM AccountUser WHERE AccountUser.idAccountUser = ItemGroup.IGUpdatedBy)
                    AS IGUpdatedBy,
	                ItemGroup.IGDateCreated,
	                ItemGroup.IGDateUpdated,
	                ItemGroup.IGStatus

                    FROM ItemGroup

                    INNER JOIN AccountUser
                	ON AccountUser.idAccountUser = ItemGroup.IGAddedBy
                    
                    WHERE(ItemGroup.IGSKU LIKE '%'+@search+'%' OR ItemGroup.IGName LIKE '%'+@search+'%')
                    ORDER BY ItemGroup.IGPriority"
        Using oConnect As New SqlConnection(sConnectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    oCommand.Parameters.AddWithValue("@search", search)
                    Using oReader = oCommand.ExecuteReader
                        While oReader.Read
                            cItem = New clsRepositoryItemGroup
                            cItem.id = oReader("idItemGroup")
                            cItem.sku = oReader("IGSKU")
                            cItem.hash = oReader("IGHash")
                            cItem.name = oReader("IGName")
                            cItem.shortagetype = oReader("IGShortageType")
                            cItem.addedby = oReader("IGAddedBy")
                            cItem.updatedby = oReader("IGUpdatedBy")
                            cItem.datecreated = oReader("IGDateCreated")
                            cItem.dateupdated = oReader("IGDateUpdated")
                            cItem.priority = oReader("IGPriority")
                            cItem.status = oReader("IGStatus")
                            list.Add(cItem)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                modGeneral.writeLog(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message, LogState.error)
            End Try
        End Using
        modGeneral.setApplicationState(ApplicationState.Ready)
        Return list
    End Function


    Public Function saveItemGroup(clsItemGroup As clsRepositoryItemGroup) As Boolean
        modGeneral.setApplicationState(ApplicationState.Busy)
        If CInt(modGeneral.executeScalar(sConnectionString, "SELECT Count(idItemGroup) FROM ItemGroup WHERE idItemGroup <>
                                                            @idItemGroup AND  IGSKU = @igsku AND IGName = @igname AND IGStatus = 1",
                                                            New clsKeyValuePair("@idItemGroup", clsItemGroup.id),
                                                            New clsKeyValuePair("@igsku", clsItemGroup.sku),
                                                            New clsKeyValuePair("@igname", clsItemGroup.name))) > 0 Then
            modGeneral.setApplicationState(ApplicationState.Ready)
            modGeneral.showMessageBox("Item Group already exisits!", MessageBoxIcon.Hand)
            Return False
        End If
        Dim b As Boolean
        Dim sQuery As String

        If clsItemGroup.id > 0 Then

            sQuery = "UPDATE ItemGroup Set idBusinessUnit = @idbusinessunit, IGSKU = @igsku, IGHash = @ighash, IGName = @igname, 
        IGShortageType = @igshortagetype, IGPriority = @rpriority, IGUpdatedBy = @igupdatedby, IGDateUpdated = getdate(), IGStatus = @IGstatus 
        WHERE idRawmats = @idrawmats"

        Else

            sQuery = "INSERT INTO ItemGroup(idBusinessUnit, IGSKU, IGHash, IGName, IGShortageType, IGPriority, RAddedBy, RUpdatedBy, 
        IGDateCreated, IGDateUpdated, IGStatus) VALUES(@idbusinessunit, @igku, @ighash, @igname, @igshortagetype, @igpriority,
                        @igaddedby, @igupdatedby, getdate(), getdate(), @igstatus)"

        End If

        Using oConnect As New SqlConnection(sConnectionString)
            Try
                oConnect.Open()
                Using oCommand As New SqlCommand(sQuery, oConnect)
                    With oCommand.Parameters
                        If clsItemGroup.id > 0 Then .AddWithValue("@idrawmats", clsItemGroup.id)
                        '.AddWithValue("@iditemgroup", clsItemGroup.idgroup)
                        '.AddWithValue("@idbusinessunit", clsItemGroup.idbusinessunit)
                        .AddWithValue("@rsku", clsItemGroup.sku)
                        '.AddWithValue("@rsapcode", clsItemGroup.sapcode)
                        .AddWithValue("@rhash", clsItemGroup.hash)
                        .AddWithValue("@rname", clsItemGroup.name)
                        '    .AddWithValue("@risperishable", clsItemGroup.isperishable)
                        .AddWithValue("@rpriority", clsItemGroup.priority)
                        .AddWithValue("@rupdatedby", CurrentAccount.idAccountUser)
                        If Not clsItemGroup.id > 0 Then .AddWithValue("@raddedby", CurrentAccount.idAccountUser)
                        .AddWithValue("@rstatus", clsItemGroup.status)
                    End With

                    b = oCommand.ExecuteNonQuery > 0
                End Using
            Catch ex As Exception
                modGeneral.writeLog(System.Reflection.MethodBase.GetCurrentMethod.Name, ex.Message, LogState.error)
            End Try
        End Using
        modGeneral.setApplicationState(ApplicationState.Ready)
        modGeneral.writeLog(System.Reflection.MethodBase.GetCurrentMethod.Name, "success", LogState.msg, False)
        Return b
    End Function

End Module


