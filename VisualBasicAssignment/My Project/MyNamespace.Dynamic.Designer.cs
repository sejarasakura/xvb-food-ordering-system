using System;
using System.ComponentModel;
using System.Diagnostics;

namespace VisualBasicAssignment.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public addfood m_addfood;

            public addfood addfood
            {
                [DebuggerHidden]
                get
                {
                    m_addfood = Create__Instance__(m_addfood);
                    return m_addfood;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_addfood))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_addfood);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AddUser m_AddUser;

            public AddUser AddUser
            {
                [DebuggerHidden]
                get
                {
                    m_AddUser = Create__Instance__(m_AddUser);
                    return m_AddUser;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AddUser))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AddUser);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public custmenu m_custmenu;

            public custmenu custmenu
            {
                [DebuggerHidden]
                get
                {
                    m_custmenu = Create__Instance__(m_custmenu);
                    return m_custmenu;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_custmenu))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_custmenu);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DebugScreen m_DebugScreen;

            public DebugScreen DebugScreen
            {
                [DebuggerHidden]
                get
                {
                    m_DebugScreen = Create__Instance__(m_DebugScreen);
                    return m_DebugScreen;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DebugScreen))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DebugScreen);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public detail m_detail;

            public detail detail
            {
                [DebuggerHidden]
                get
                {
                    m_detail = Create__Instance__(m_detail);
                    return m_detail;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_detail))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_detail);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public edit m_edit;

            public edit edit
            {
                [DebuggerHidden]
                get
                {
                    m_edit = Create__Instance__(m_edit);
                    return m_edit;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_edit))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_edit);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ForgotPassword m_ForgotPassword;

            public ForgotPassword ForgotPassword
            {
                [DebuggerHidden]
                get
                {
                    m_ForgotPassword = Create__Instance__(m_ForgotPassword);
                    return m_ForgotPassword;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ForgotPassword))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ForgotPassword);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form2 m_Form2;

            public Form2 Form2
            {
                [DebuggerHidden]
                get
                {
                    m_Form2 = Create__Instance__(m_Form2);
                    return m_Form2;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form2))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form2);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_Alert m_Form_Alert;

            public Form_Alert Form_Alert
            {
                [DebuggerHidden]
                get
                {
                    m_Form_Alert = Create__Instance__<Form_Alert>(m_Form_Alert);
                    return m_Form_Alert;
                }

                [DebuggerHidden]
                set
                {
                    if (object.ReferenceEquals(value, m_Form_Alert))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__<Form_Alert>(ref m_Form_Alert);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public HomeScreen m_HomeScreen;

            public HomeScreen HomeScreen
            {
                [DebuggerHidden]
                get
                {
                    m_HomeScreen = Create__Instance__(m_HomeScreen);
                    return m_HomeScreen;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_HomeScreen))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_HomeScreen);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Login m_Login;

            public Login Login
            {
                [DebuggerHidden]
                get
                {
                    m_Login = Create__Instance__(m_Login);
                    return m_Login;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Login))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Login);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Master m_Master;

            public Master Master
            {
                [DebuggerHidden]
                get
                {
                    m_Master = Create__Instance__(m_Master);
                    return m_Master;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Master))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Master);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModifyUser m_ModifyUser;

            public ModifyUser ModifyUser
            {
                [DebuggerHidden]
                get
                {
                    m_ModifyUser = Create__Instance__(m_ModifyUser);
                    return m_ModifyUser;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ModifyUser))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModifyUser);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public PaymentStep1 m_PaymentStep1;

            public PaymentStep1 PaymentStep1
            {
                [DebuggerHidden]
                get
                {
                    m_PaymentStep1 = Create__Instance__(m_PaymentStep1);
                    return m_PaymentStep1;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_PaymentStep1))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_PaymentStep1);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public PaymentStep2 m_PaymentStep2;

            public PaymentStep2 PaymentStep2
            {
                [DebuggerHidden]
                get
                {
                    m_PaymentStep2 = Create__Instance__(m_PaymentStep2);
                    return m_PaymentStep2;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_PaymentStep2))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_PaymentStep2);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public PaymentStep3 m_PaymentStep3;

            public PaymentStep3 PaymentStep3
            {
                [DebuggerHidden]
                get
                {
                    m_PaymentStep3 = Create__Instance__(m_PaymentStep3);
                    return m_PaymentStep3;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_PaymentStep3))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_PaymentStep3);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Profile m_Profile;

            public Profile Profile
            {
                [DebuggerHidden]
                get
                {
                    m_Profile = Create__Instance__(m_Profile);
                    return m_Profile;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Profile))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Profile);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Register m_Register;

            public Register Register
            {
                [DebuggerHidden]
                get
                {
                    m_Register = Create__Instance__(m_Register);
                    return m_Register;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Register))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Register);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SplashScreen m_SplashScreen;

            public SplashScreen SplashScreen
            {
                [DebuggerHidden]
                get
                {
                    m_SplashScreen = Create__Instance__(m_SplashScreen);
                    return m_SplashScreen;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SplashScreen))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SplashScreen);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public staffmenu m_staffmenu;

            public staffmenu staffmenu
            {
                [DebuggerHidden]
                get
                {
                    m_staffmenu = Create__Instance__(m_staffmenu);
                    return m_staffmenu;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_staffmenu))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_staffmenu);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public UserRecordReport m_UserRecordReport;

            public UserRecordReport UserRecordReport
            {
                [DebuggerHidden]
                get
                {
                    m_UserRecordReport = Create__Instance__(m_UserRecordReport);
                    return m_UserRecordReport;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_UserRecordReport))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UserRecordReport);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public VisualBasicAssignment_CustomAlertBoxDemo_Form1 m_VisualBasicAssignment_CustomAlertBoxDemo_Form1;

            public VisualBasicAssignment_CustomAlertBoxDemo_Form1 VisualBasicAssignment_CustomAlertBoxDemo_Form1
            {
                [DebuggerHidden]
                get
                {
                    m_VisualBasicAssignment_CustomAlertBoxDemo_Form1 = Create__Instance__<VisualBasicAssignment_CustomAlertBoxDemo_Form1>(m_VisualBasicAssignment_CustomAlertBoxDemo_Form1);
                    return m_VisualBasicAssignment_CustomAlertBoxDemo_Form1;
                }

                [DebuggerHidden]
                set
                {
                    if (object.ReferenceEquals(value, m_VisualBasicAssignment_CustomAlertBoxDemo_Form1))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__<VisualBasicAssignment_CustomAlertBoxDemo_Form1>(ref m_VisualBasicAssignment_CustomAlertBoxDemo_Form1);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public VisualBasicAssignment_Form1 m_VisualBasicAssignment_Form1;

            public VisualBasicAssignment_Form1 VisualBasicAssignment_Form1
            {
                [DebuggerHidden]
                get
                {
                    m_VisualBasicAssignment_Form1 = Create__Instance__<VisualBasicAssignment_Form1>(m_VisualBasicAssignment_Form1);
                    return m_VisualBasicAssignment_Form1;
                }

                [DebuggerHidden]
                set
                {
                    if (object.ReferenceEquals(value, m_VisualBasicAssignment_Form1))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__<VisualBasicAssignment_Form1>(ref m_VisualBasicAssignment_Form1);
                }
            }
        }
    }
}