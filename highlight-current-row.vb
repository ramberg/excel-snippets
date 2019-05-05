' (1) Create a formula "Formulas > Define Name" which is called CurrentRow and Refers to "=1"
' (2) Create a conditional formatting "Home > C.F." which evaluates the formular "=ROW(A1)=CurrentRow"
' (3) Create the following macro
' (4) Save Excel File as xlsm (w/ macros)

Private Sub Worksheet_SelectionChange(ByVal Target As Range)
    With ThisWorkbook.Names("CurrentRow")
        .Name = "CurrentRow"
        .RefersToR1C1 = "=" & ActiveCell.Row
    End With
End Sub

'Source: youtube channel "Adobe in a Minute"
