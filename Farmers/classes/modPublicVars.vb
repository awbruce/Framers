Namespace theSaint

    Module modPublicVars

        Public Enum dataTypes
            _String
            _Integer
            _Double
            _Decimal
            _Date
            _Boolean
        End Enum

        Public Enum FormState
            addStateAddMode = 0
            addStateEditMode = 1
            addStatePopupMode = 2
            addStateViewMode = 3
            addStateDeleteMode = 4
        End Enum

        Public sysException As Exception = Nothing
        Public HubtelErrorCode As Integer = 0
        Public InfobipErrorCode As Integer = 0
        Public EmergentErrorCode As Integer = 0
        Public TempFileNames2 As String = Nothing
        Public sys_settings As New system_settings
    End Module

End Namespace

