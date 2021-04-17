﻿using System;

namespace VisualBasicAssignment
{
    public partial class SalesReport
    {
        public SalesReport()
        {
            InitializeComponent();
            _Guna2DateTimePicker1.Name = "Guna2DateTimePicker1";
        }

        // Select Case productName, productDetail, productcate, productpri, productquan, SUM(Quantity) As SUM_OF_PRO_QUANTITY, ProductId FROM VIEW_PAYMENT GROUP BY ProductId, productName, productDetail, productcate, productquan, productstatus, productpri ORDER BY SUM_OF_PRO_QUANTITY DESC;

        // Dim aggregate = From wod In db.WorkOrderDetails
        // Group wod By Key = New With { Key wod.PriceCodeID, Key Description }
        // Into Group
        // Select Case agg = Key.PriceCodeID,
        // Key.Description,
        // Quantity = Group.Sum(Function(wod) wod.Quantity),
        // Subtotal = Group.Sum(Function(wod) wod.Subtotal),
        // Total = Group.Sum(Function(wod) wod.Total)




        private void Page_Load(object sender, EventArgs e)
        {
            UpdatesRecords(DateTime.Now);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvReport.Rows.Clear();
        }

        private void UpdatesRecords(DateTime xDate)
        {
            var u = DatabaseConnections.GetLoginUser();
            using (var db = new FoodShopEntities1())
            {
                try
                {
                    ;
#error Cannot convert AssignmentStatementSyntax - see comment for details
                    /* Cannot convert InvocationExpressionSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax'.
                       at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<>c__DisplayClass78_0.<<ConvertInvocationAsync>g__ConvertInvocationSubExpression|0>d.MoveNext()
                    --- End of stack trace from previous location where exception was thrown ---
                       at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<ConvertInvocationAsync>d__78.MoveNext()
                    --- End of stack trace from previous location where exception was thrown ---
                       at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitInvocationExpression>d__77.MoveNext()
                    --- End of stack trace from previous location where exception was thrown ---
                       at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__5`1.MoveNext()

                    Input: (
                                        From d In db.PaymentDetailsReportViews
                                        Where d.payment_date.Value.Year = xDate.Year And d.payment_date.Value.Month = xDate.Month
                                        Group By g = New With {d.food_id, d.title, d.price, d.descriptions} Into Group
                                        Select
                                            g.food_id,
                                            g.title,
                                            g.descriptions,
                                            g.price,
                                            quantity = Group.Sum(Function(d) d.quantity),
                                            total = Group.Sum(Function(d) d.quantity) * g.price
                                        ).ToList()

                    Context:
                                    Me.dgvReport.DataSource = (
                                        From d In db.PaymentDetailsReportViews
                                        Where d.payment_date.Value.Year = xDate.Year And d.payment_date.Value.Month = xDate.Month
                                        Group By g = New With {d.food_id, d.title, d.price, d.descriptions} Into Group
                                        Select
                                            g.food_id,
                                            g.title,
                                            g.descriptions,
                                            g.price,
                                            quantity = Group.Sum(Function(d) d.quantity),
                                            total = Group.Sum(Function(d) d.quantity) * g.price
                                        ).ToList()

                     */
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: {0}", ex);
                }
            }
        }

        private void Guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var _date = Guna2DateTimePicker1.Value;
            UpdatesRecords(_date);
        }
    }
}