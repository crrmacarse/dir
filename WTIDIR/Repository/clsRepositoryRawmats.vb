Public Class clsRepositoryRawmats

    Private _id As Integer
    Private _sku As String
    Private _sapcode As String
    Private _hash As String
    Private _idgroup As Integer
    Private _group As String
    Private _name As String
    Private _isperishable As Boolean
    Private _idbusinessunit As Integer
    Private _businessunit As String
    Private _addedby As String
    Private _updatedby As String
    Private _datecreated As DateTime
    Private _dateupdated As DateTime
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

    Public Property sapcode As String
        Get
            Return _sapcode
        End Get
        Set(value As String)
            _sapcode = value
        End Set
    End Property

    Public Property hash As String
        Get
            Return " "
            '            Return _hash
        End Get
        Set(value As String)
            _hash = value
        End Set
    End Property

    Public Property idgroup As Integer
        Get
            Return _idgroup
        End Get
        Set(value As Integer)
            _idgroup = value
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

    Public Property isperishable As Boolean
        Get
            Return _isperishable
        End Get
        Set(value As Boolean)
            _isperishable = value
        End Set
    End Property

    Public Property idbusinessunit As Integer
        Get
            Return 1000
            'Return _idbusinessunit
        End Get
        Set(value As Integer)
            _idbusinessunit = value
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