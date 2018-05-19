Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Actions

Namespace WinWebSolution.Module
	Public Class MyDetailsWorker
		Inherits ViewController
		Private saStaticTestAction As SimpleAction
		Private components As System.ComponentModel.IContainer
		Private dynamicTestActionCore As SimpleAction
		Public Sub New()
			'Static action
			InitializeComponent()
			RegisterActions(components)
			'Dynamic action
			dynamicTestActionCore = New SimpleAction(Me, "DynamicTestAction", PredefinedCategory.RecordEdit)
			dynamicTestActionCore.Caption = "Dynamic Test Action"
		End Sub
		Protected Overrides Overloads Sub OnFrameAssigned()
			MyBase.OnFrameAssigned()
			If Application IsNot Nothing Then
				Dim os As ObjectSpace = Application.CreateObjectSpace()
				dynamicTestActionCore.TargetViewId = Application.GetDetailViewId(SecuritySystem.UserType)
				dynamicTestActionCore.TargetObjectsCriteria = CriteriaOperator.Parse("?=?", os.GetKeyPropertyName(SecuritySystem.UserType), SecuritySystem.CurrentUserId).ToString()
			End If
		End Sub
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.saStaticTestAction = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' saStaticTestAction
			' 
			Me.saStaticTestAction.Caption = "Static Test Action"
			Me.saStaticTestAction.Category = "RecordEdit"
			Me.saStaticTestAction.Id = "StaticTestAction"
			Me.saStaticTestAction.Tag = Nothing
			Me.saStaticTestAction.TargetObjectsCriteria = "Oid='@CurrentUserID'"
			Me.saStaticTestAction.TargetViewId = "SimpleUser_DetailView"
			Me.saStaticTestAction.TypeOfView = Nothing

		End Sub
	End Class
End Namespace