Namespace theSaint

    Module modVarTypes

        Public Structure system_settings
            Dim SYSTEM_DateTime As DateTime
            Dim SYSTEM_SMS_ClientID As String
            Dim SYSTEM_SMS_SecretCode As String
            Dim SYSTEM_SMS_CountryCode As String
            Dim SYSTEM_SMS_DebitRecepient As String
            Dim SYSTEM_SMS_Sender As String
            Dim SYSTEM_theme As Integer
            Dim SYSTEM_style As Integer

            Dim ftpURL As String
            Dim ftpUsername As String
            Dim ftpPassword As String
            Dim ftpLocaldir As String
        End Structure

        Public Enum MsgBoxMessages
            OPERATION_Successful
            OPERATION_Failed
            OPERATION_Exception
            OPERATION_InvalidInput
            OPERATION_NonEdit
            OPERATION_SuccessfulRestart
        End Enum

    End Module

End Namespace
