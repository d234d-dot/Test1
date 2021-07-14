using LF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VisiWin.ApplicationFramework;

namespace LF.PID
{
    [ExportAdapter(nameof(YWeicheDialogViewAdapter))]
    public class YWeicheDialogViewAdapter : AdapterBase
    {

        #region Properties

        public YWeiche YWeiche
        {
            get { return (YWeiche)GetValue(YWeicheProperty); }
            set { SetValue(YWeicheProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Motor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty YWeicheProperty =
            DependencyProperty.Register(nameof(YWeiche), typeof(YWeiche), typeof(YWeicheDialogViewAdapter));

        #region CommandPanel

        public string OperatingModeVariableName
        {
            get { return (string)GetValue(OperatingModeVariableNameProperty); }
            set { SetValue(OperatingModeVariableNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OperatingModeVariableName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OperatingModeVariableNameProperty =
            DependencyProperty.Register(nameof(OperatingModeVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string HandPosCloseVariableName
        //{
        //    get { return (string)GetValue(HandPosCloseVariableNameProperty); }
        //    set { SetValue(HandPosCloseVariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for JogBackwardVariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty HandPosCloseVariableNameProperty =
        //    DependencyProperty.Register(nameof(HandPosCloseVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        public string HandGeradeVariableName
        {
            get { return (string)GetValue(HandGeradeVariableNameProperty); }
            set { SetValue(HandGeradeVariableNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for JogForwardVariableName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HandGeradeVariableNameProperty =
            DependencyProperty.Register(nameof(HandGeradeVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        public string HandKurveVariableName
        {
            get { return (string)GetValue(HandKurveVariableNameProperty); }
            set { SetValue(HandKurveVariableNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for JogForwardVariableName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HandKurveVariableNameProperty =
            DependencyProperty.Register(nameof(HandKurveVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));


        //public string HandPosOpenVariableName
        //{
        //    get { return (string)GetValue(HandPosOpenVariableNameProperty); }
        //    set { SetValue(HandPosOpenVariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for RunVariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty HandPosOpenVariableNameProperty =
        //    DependencyProperty.Register(nameof(HandPosOpenVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        #endregion

        #region State

        public string Feedback1VariableName
        {
            get { return (string)GetValue(Feedback1VariableNameProperty); }
            set { SetValue(Feedback1VariableNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Feedback1VariableName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Feedback1VariableNameProperty =
            DependencyProperty.Register(nameof(Feedback1VariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        public string Feedback2VariableName
        {
            get { return (string)GetValue(Feedback2VariableNameProperty); }
            set { SetValue(Feedback2VariableNameProperty, value); }

        }

        // Using a DependencyProperty as the backing store for Feedback2VariableName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Feedback2VariableNameProperty =
            DependencyProperty.Register(nameof(Feedback2VariableName), typeof(string), typeof(YWeicheDialogViewAdapter));


      


        //public string Feedback3VariableName
        //{
        //    get { return (string)GetValue(Feedback3VariableNameProperty); }
        //    set { SetValue(Feedback3VariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Feedback3VariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty Feedback3VariableNameProperty =
        //    DependencyProperty.Register(nameof(Feedback3VariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string Feedback4VariableName
        //{
        //    get { return (string)GetValue(Feedback4VariableNameProperty); }
        //    set { SetValue(Feedback4VariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Feedback4VariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty Feedback4VariableNameProperty =
        //    DependencyProperty.Register(nameof(Feedback4VariableName), typeof(string), typeof(YWeicheDialogViewAdapter));


        public string Feedback1LocalizableText
        {
            get { return (string)GetValue(Feedback1LocalizableTextProperty); }
            set { SetValue(Feedback1LocalizableTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Feedback1LocalizableText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Feedback1LocalizableTextProperty =
            DependencyProperty.Register(nameof(Feedback1LocalizableText), typeof(string), typeof(YWeicheDialogViewAdapter));

        public string Feedback2LocalizableText
        {
            get { return (string)GetValue(Feedback2LocalizableTextProperty); }
            set { SetValue(Feedback2LocalizableTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Feedback2LocalizableText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Feedback2LocalizableTextProperty =
            DependencyProperty.Register(nameof(Feedback2LocalizableText), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string Feedback3LocalizableText
        //{
        //    get { return (string)GetValue(Feedback3LocalizableTextProperty); }
        //    set { SetValue(Feedback3LocalizableTextProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Feedback3LocalizableText.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty Feedback3LocalizableTextProperty =
        //    DependencyProperty.Register(nameof(Feedback3LocalizableText), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string Feedback4LocalizableText
        //{
        //    get { return (string)GetValue(Feedback4LocalizableTextProperty); }
        //    set { SetValue(Feedback4LocalizableTextProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Feedback4LocalizableText.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty Feedback4LocalizableTextProperty =
        //    DependencyProperty.Register(nameof(Feedback4LocalizableText), typeof(string), typeof(YWeicheDialogViewAdapter));


        public string ActualPositionVariableName
        {
            get { return (string)GetValue(ActualPositionVariableNameProperty); }
            set { SetValue(ActualPositionVariableNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ActualPositionVariableName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActualPositionVariableNameProperty =
            DependencyProperty.Register(nameof(ActualPositionVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        #endregion

        #region Settings

        //public string SettingOnDelayVariableName
        //{
        //    get { return (string)GetValue(SettingOnDelayVariableNameProperty); }
        //    set { SetValue(SettingOnDelayVariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for SettingOnDelayVariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SettingOnDelayVariableNameProperty =
        //    DependencyProperty.Register(nameof(SettingOnDelayVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string SettingOffDelayVariableName
        //{
        //    get { return (string)GetValue(SettingOffDelayVariableNameProperty); }
        //    set { SetValue(SettingOffDelayVariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for SettingOffDelayVariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SettingOffDelayVariableNameProperty =
        //    DependencyProperty.Register(nameof(SettingOffDelayVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string SettingPositionCloseVariableName
        //{
        //    get { return (string)GetValue(SettingPositionCloseVariableNameProperty); }
        //    set { SetValue(SettingPositionCloseVariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for SettingPowerVariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SettingPositionCloseVariableNameProperty =
        //    DependencyProperty.Register(nameof(SettingPositionCloseVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string SettingPositionOneVariableName
        //{
        //    get { return (string)GetValue(SettingPositionOneVariableNameProperty); }
        //    set { SetValue(SettingPositionOneVariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for SettingCurrentVariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SettingPositionOneVariableNameProperty =
        //    DependencyProperty.Register(nameof(SettingPositionOneVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string SettingPositionTwoVariableName
        //{
        //    get { return (string)GetValue(SettingPositionTwoVariableNameProperty); }
        //    set { SetValue(SettingPositionTwoVariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for SettingTensionVariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SettingPositionTwoVariableNameProperty =
        //    DependencyProperty.Register(nameof(SettingPositionTwoVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        //public string SettingPositionOpenVariableName
        //{
        //    get { return (string)GetValue(SettingPositionOpenVariableNameProperty); }
        //    set { SetValue(SettingPositionOpenVariableNameProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for SettingNominalSpeedVariableName.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SettingPositionOpenVariableNameProperty =
        //    DependencyProperty.Register(nameof(SettingPositionOpenVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));


        #endregion

        #region Service

        public string ServiceForceRequirementsVariableName
        {
            get { return (string)GetValue(ServiceForceRequirementsVariableNameProperty); }
            set { SetValue(ServiceForceRequirementsVariableNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ServiceForceRequirementsVariableName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ServiceForceRequirementsVariableNameProperty =
            DependencyProperty.Register(nameof(ServiceForceRequirementsVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        public string ServiceForceSafetyVariableName
        {
            get { return (string)GetValue(ServiceForceSafetyVariableNameProperty); }
            set { SetValue(ServiceForceSafetyVariableNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ServiceForceSafetyVariableName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ServiceForceSafetyVariableNameProperty =
            DependencyProperty.Register(nameof(ServiceForceSafetyVariableName), typeof(string), typeof(YWeicheDialogViewAdapter));

        #endregion

        #endregion

        #region Methods

        public void ShowDialog(YWeiche yweiche)
        {
            var structureVariableName = yweiche.GetStructureVariableName();
            var structureLocalizableText = yweiche.GetStructureLocalizableText();

            if (string.IsNullOrEmpty(structureVariableName))
                return;

            this.YWeiche = yweiche;
            this.OperatingModeVariableName = structureVariableName + "{.Betriebsart}";
            //this.HandPosCloseVariableName = structureVariableName + "{.Hand.PosClose}";
            this.HandGeradeVariableName = structureVariableName + "{.Hand.0Gerade}";
            this.HandKurveVariableName = structureVariableName + "{.Hand.90Kurve}";
            //this.HandPosOpenVariableName = structureVariableName + "{.Hand.PosOpen}";

            this.Feedback1VariableName = structureVariableName + "{.Rueckmeldungen[0]}";
            this.Feedback2VariableName = structureVariableName + "{.Rueckmeldungen[1]}";
            //this.Feedback3VariableName = structureVariableName + "{.Rueckmeldungen[2]}";
            //this.Feedback4VariableName = structureVariableName + "{.Rueckmeldungen[3]}";
           
            this.Feedback1LocalizableText = structureLocalizableText + ".Feedback1";
            this.Feedback2LocalizableText = structureLocalizableText + ".Feedback2";
            //this.Feedback3LocalizableText = structureLocalizableText + ".Feedback3";
            //this.Feedback4LocalizableText = structureLocalizableText + ".Feedback4";

            this.ActualPositionVariableName = structureVariableName + "{.Ist.Position}";
            

            //this.SettingOnDelayVariableName = structureVariableName + "{.Soll.Einschaltverzoegerung}";
            //this.SettingOffDelayVariableName = structureVariableName + "{.Soll.Ausschaltverzoegerung}";
            //this.SettingPositionCloseVariableName = structureVariableName + "{.Soll.PositionGeschlossen}";
            //this.SettingPositionOneVariableName = structureVariableName + "{.Soll.Position1}";
            //this.SettingPositionTwoVariableName = structureVariableName + "{.Soll.Position2}";
            //this.SettingPositionOpenVariableName = structureVariableName + "{.Soll.PositionOffen}";

            this.ServiceForceRequirementsVariableName = structureVariableName + "{.Hand.UeberbrueckungBedingungen}";
            this.ServiceForceSafetyVariableName = structureVariableName + "{.Hand.UeberbrueckungSafety}";

            DialogView.Show(nameof(YWeicheDialogView), structureLocalizableText + ".Caption", DialogButton.Custom);
        }

        #endregion

    }
}
