Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Entidades
Imports BLL

<TestClass()> Public Class PlanAhorrosTest

    <TestMethod()> Public Sub Guardar()

        Dim PlanAhorro As PlanAhorros = New PlanAhorros(0, "Motor", 4, 1, 1000)
        Assert.IsTrue(PlanAhorrosBLL.Guardar(PlanAhorro))

    End Sub

    <TestMethod()> Public Sub Buscar()

        Dim paso = PlanAhorrosBLL.Buscar(1)
        Assert.AreNotEqual(0, paso)

    End Sub

    <TestMethod()> Public Sub Eliminar()

        Dim PlanAhorro As PlanAhorros = New PlanAhorros(0, "Motor", 4, 1, 1000)
        PlanAhorrosBLL.Guardar(PlanAhorro)
        Assert.IsTrue(PlanAhorrosBLL.Eliminar(1))

    End Sub

    <TestMethod()> Public Sub Modificar()

        Dim PlanAhorro As PlanAhorros = New PlanAhorros(0, "Motor", 4, 1, 1000)
        PlanAhorrosBLL.Guardar(PlanAhorro)
        Assert.IsTrue(PlanAhorrosBLL.Modificar(PlanAhorro))

    End Sub

End Class