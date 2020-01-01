Imports System.IO

Public Class Form1
    'Button für den Import der Stempeluhr CSV Datei
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdImport.Click
        'Erzeuge ein "File Choser" Objekt
        Dim ofd As New OpenFileDialog With
{
.Multiselect = False,
.InitialDirectory = "X:\DatenBetrieb",
.Filter = "CSV Datei (*.csv)|*.csv",
.Title = "Stempeluhr CSV Datei wählen"
}
        'TODO: Fehler abfangen, beim dem Versuch CSV Datei einzubinden während sie bereits in einem anderen Programm (z.B. Excel) geöffnet ist.
        If ofd.ShowDialog = DialogResult.OK Then
            'Lese alle Zeilen ein
            Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName, System.Text.Encoding.Default).ToList()
            'Erzeuge Liste vom Typ Mitarbeiter
            Dim list As List(Of Mitarbeiter) = New List(Of Mitarbeiter)
            Dim IdCompare As Integer
            IdCompare = 0
            For i As Integer = 1 To lines.Count - 1
                Dim data As String() = lines(i).Split(vbTab)
                'Prüfe, ob die ID bereits dran war, wenn nicht setze IdCompare auf den neuen Wert
                If IdCompare = data(5) Then
                    Continue For
                End If
                IdCompare = data(5)
                'Erzeuge einen neuen Mitarbeiter mit den Werten aus der CSV Datei
                list.Add(New Mitarbeiter() With {
                         .MitarbeiterID = data(5),
                         .Nachname = data(3),
                         .Vorname = data(2)
                    })
            Next
            'TODO: Wie speichern in die erstellte Datenbank?
            TableBindingSource.DataSource = list
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "StempeluhrDataSet.Table". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.TableTableAdapter.Fill(Me.StempeluhrDataSet.Table)

    End Sub
End Class
