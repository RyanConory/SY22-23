Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Functions
<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim f As New Form1
        asser(f.trianglearea(2, 1) = 1)
    End Sub

End Class