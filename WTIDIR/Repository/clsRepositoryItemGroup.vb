Public Class clsRepositoryItemGroup

    Private _id As Integer
    Private _sku As String
    Private _name As String
    Private _type As String
    Private _shortagetype As Integer
    Private _addedby As String
    Private _updatedby As String
    Private _datecreated As DateTime
    Private _dateupdated As DateTime
    Private _hash As String
    Private _priority As Integer
    Private _status As Boolean

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property sku As String
        Get
            Return _sku
        End Get
        Set(value As String)
            _sku = value
        End Set
    End Property

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    Public Property shortagetype As Integer
        Get
            Return _shortagetype
        End Get
        Set(value As Integer)
            _shortagetype = value
        End Set
    End Property

    Public Property addedby As String
        Get
            Return _addedby
        End Get
        Set(value As String)
            _addedby = value
        End Set
    End Property

    Public Property updatedby As String
        Get
            Return _updatedby
        End Get
        Set(value As String)
            _updatedby = value
        End Set
    End Property

    Public Property datecreated As DateTime
        Get
            Return _datecreated
        End Get
        Set(value As DateTime)
            _datecreated = value
        End Set
    End Property

    Public Property dateupdated As DateTime
        Get
            Return _dateupdated
        End Get
        Set(value As DateTime)
            _dateupdated = value
        End Set
    End Property

    Public Property hash As String
        Get
            Return _hash
        End Get
        Set(value As String)
            _hash = value
        End Set
    End Property

    Public Property priority As Integer
        Get
            Return _priority
        End Get
        Set(value As Integer)
            _priority = value
        End Set
    End Property

    Public Property status As Boolean
        Get
            Return _status
        End Get
        Set(value As Boolean)
            _status = value
        End Set
    End Property

    Public ReadOnly Property CreatedInfo As String
        Get
            Return "Added by: " & _addedby & " on " & _datecreated
        End Get
    End Property

    Public ReadOnly Property UpdatedInfo As String
        Get
            Return "Updated by: " & _updatedby & " on " & _dateupdated
        End Get
    End Property

End Class