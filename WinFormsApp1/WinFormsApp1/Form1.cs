public partial class Form1 : Form
{
    public Form1()
    {
  
        InitializeLayout();
    }

    private void InitializeLayout()
    {
        // Create panels for each section
        var panelTransaction = new Panel { Location = new Point(10, 10), Size = new Size(350, 200) };
        var panelBudget = new Panel { Location = new Point(10, 220), Size = new Size(350, 200) };
        var panelSavings = new Panel { Location = new Point(10, 430), Size = new Size(350, 200) };

        // Transaction Section
        var lblAmount = new Label { Text = "Amount", Location = new Point(10, 10) };
        var txtAmount = new TextBox { Location = new Point(80, 10), Width = 200 };

        var lblCategory = new Label { Text = "Category", Location = new Point(10, 40) };
        var txtCategory = new TextBox { Location = new Point(80, 40), Width = 200 };

        var lblTransactionType = new Label { Text = "Transaction Type", Location = new Point(10, 70) };
        var cmbTransactionType = new ComboBox { Location = new Point(120, 70), Width = 160 };
        cmbTransactionType.Items.AddRange(new string[] { "Income", "Expense" });

        var btnAddTransaction = new Button { Text = "Add Transaction", Location = new Point(10, 100) };
        var listBoxTransactions = new ListBox { Location = new Point(10, 130), Size = new Size(330, 60) };

        // Add controls to panel
        panelTransaction.Controls.Add(lblAmount);
        panelTransaction.Controls.Add(txtAmount);
        panelTransaction.Controls.Add(lblCategory);
        panelTransaction.Controls.Add(txtCategory);
        panelTransaction.Controls.Add(lblTransactionType);
        panelTransaction.Controls.Add(cmbTransactionType);
        panelTransaction.Controls.Add(btnAddTransaction);
        panelTransaction.Controls.Add(listBoxTransactions);

        // Budget Section
        var lblBudgetCategory = new Label { Text = "Category", Location = new Point(10, 10) };
        var txtBudgetCategory = new TextBox { Location = new Point(80, 10), Width = 200 };

        var lblBudgetAmount = new Label { Text = "Budget Amount", Location = new Point(10, 40) };
        var txtBudgetAmount = new TextBox { Location = new Point(120, 40), Width = 160 };

        var btnCheckBudget = new Button { Text = "Check Budget", Location = new Point(10, 70) };
        var lblBudgetStatus = new Label { Location = new Point(10, 100), Width = 330 };

        // Add controls to panel
        panelBudget.Controls.Add(lblBudgetCategory);
        panelBudget.Controls.Add(txtBudgetCategory);
        panelBudget.Controls.Add(lblBudgetAmount);
        panelBudget.Controls.Add(txtBudgetAmount);
        panelBudget.Controls.Add(btnCheckBudget);
        panelBudget.Controls.Add(lblBudgetStatus);

        // Savings Section
        var lblGoalName = new Label { Text = "Goal Name", Location = new Point(10, 10) };
        var txtGoalName = new TextBox { Location = new Point(80, 10), Width = 200 };

        var lblTargetAmount = new Label { Text = "Target Amount", Location = new Point(10, 40) };
        var txtTargetAmount = new TextBox { Location = new Point(120, 40), Width = 160 };

        var lblCurrentAmount = new Label { Text = "Current Amount", Location = new Point(10, 70) };
        var txtCurrentAmount = new TextBox { Location = new Point(120, 70), Width = 160 };

        var btnRecommendSavings = new Button { Text = "Recommend Savings", Location = new Point(10, 100) };

        // Add controls to panel
        panelSavings.Controls.Add(lblGoalName);
        panelSavings.Controls.Add(txtGoalName);
        panelSavings.Controls.Add(lblTargetAmount);
        panelSavings.Controls.Add(txtTargetAmount);
        panelSavings.Controls.Add(lblCurrentAmount);
        panelSavings.Controls.Add(txtCurrentAmount);
        panelSavings.Controls.Add(btnRecommendSavings);

        // Add panels to form
        this.Controls.Add(panelTransaction);
        this.Controls.Add(panelBudget);
        this.Controls.Add(panelSavings);
    }
}
