Public Class clsRepositoryProduct

    Private _id As Integer
    Private _sku As String
    Private _group As String
    Private _name As String
    Private _bulkdiscount As Boolean
    Private _addedby As String
    Private _updatedby As String
    Private _datecreated As DateTime
    Private _dateupdated As DateTime
    Private _businessunit As String
    Private _priorty As Integer
    Private _hash As String
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

    Public Property group As String
        Get
            Return _group
        End Get
        Set(value As String)
            _group = value
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

    Public Property bulkdiscount As Boolean
        Get
            Return _bulkdiscount
        End Get
        Set(value As Boolean)
            _bulkdiscount = value
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

    Public Property businessunit As String
        Get
            Return _businessunit
        End Get
        Set(value As String)
            _businessunit = value
        End Set
    End Property

    Public Property priorty As Integer
        Get
            Return _priorty
        End Get
        Set(value As Integer)
            _priorty = value
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