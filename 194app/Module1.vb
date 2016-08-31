Public Module Module1
    Public d1, d2 As DateTime
    Public msg1 As String
    Public k As Integer

    Public Function DInterval(sinterval As Integer) As String
        Dim Ddef, hdef, mdef, sdef As Integer
        Ddef = CStr(sinterval \ 86400)
        hdef = CStr((sinterval - (Ddef * 86400)) \ 3600)
        mdef = CStr((sinterval - (Ddef * 86400) - (hdef * 3600)) \ 60)
        sdef = CStr(sinterval Mod 60)
        If Ddef > 0 Then DInterval = Ddef & " д." Else DInterval = ""
        If Len(hdef) = 1 Then mdef = "0" & hdef
        If Len(mdef) = 1 Then mdef = "0" & mdef
        If Len(sdef) = 1 Then mdef = "0" & sdef
        DInterval = DInterval & hdef & ":" & mdef & ":" & sdef

    End Function


End Module
