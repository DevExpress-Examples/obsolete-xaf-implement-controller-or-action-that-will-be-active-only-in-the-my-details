using System;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Actions;

namespace WinWebSolution.Module {
    public class MyDetailsWorker : ViewController {
        private SimpleAction saStaticTestAction;
        private System.ComponentModel.IContainer components;
        private SimpleAction dynamicTestActionCore;
        public MyDetailsWorker() {
            //Static action
            InitializeComponent();
            RegisterActions(components);
            //Dynamic action
            dynamicTestActionCore = new SimpleAction(this, "DynamicTestAction", PredefinedCategory.RecordEdit);
            dynamicTestActionCore.Caption = "Dynamic Test Action";
        }
        protected override void OnFrameAssigned() {
            base.OnFrameAssigned();
            if (Application != null) {
                ObjectSpace os = Application.CreateObjectSpace();
                dynamicTestActionCore.TargetViewId = Application.GetDetailViewId(SecuritySystem.UserType);
                dynamicTestActionCore.TargetObjectsCriteria = CriteriaOperator.Parse("?=?", os.GetKeyPropertyName(SecuritySystem.UserType), SecuritySystem.CurrentUserId).ToString();
            }
        }
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.saStaticTestAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saStaticTestAction
            // 
            this.saStaticTestAction.Caption = "Static Test Action";
            this.saStaticTestAction.Category = "RecordEdit";
            this.saStaticTestAction.Id = "StaticTestAction";
            this.saStaticTestAction.Tag = null;
            this.saStaticTestAction.TargetObjectsCriteria = "Oid=\'@CurrentUserID\'";
            this.saStaticTestAction.TargetViewId = "SimpleUser_DetailView";
            this.saStaticTestAction.TypeOfView = null;

        }
    }
}