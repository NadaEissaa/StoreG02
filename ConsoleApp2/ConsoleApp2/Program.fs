open System
open System.Drawing
open System.Windows.Forms
open System.Collections.Generic

// Define types for transactions, budgets, and savings goals
type Transaction = { Amount: decimal; Category: string; Type: string }
type Budget = { Category: string; Limit: decimal }
type SavingsGoal = { Name: string; Target: decimal; Current: decimal }

// Data storage
let transactions = new List<Transaction>()
let budgets = new List<Budget>()
let savingsGoals = new List<SavingsGoal>()

// Helper function to display a message box
let showMessage message = MessageBox.Show(message) |> ignore

// Helper function to update a ListBox
let updateListBox (listBox: ListBox) (items: seq<string>) =
    listBox.Items.Clear()
    items |> Seq.iter (listBox.Items.Add >> ignore)

// Main Application GUI
let createMainForm () =
    let form = new Form(Text = "Financial Tracker", Size = Size(900, 700), StartPosition = FormStartPosition.CenterScreen)
    form.BackColor <- Color.White

    let tabControl = new TabControl(Dock = DockStyle.Fill)
    tabControl.Font <- new Font("Arial", 10.0F, FontStyle.Bold)

    // **Expenses Tab**
    let tabExpenses = new TabPage(Text = "Expenses")
    tabExpenses.BackColor <- Color.LightGray
    let lblAmount = new Label(Text = "Amount:", Location = Point(20, 20), AutoSize = true)
    let txtAmount = new TextBox(Location = Point(120, 20), Size = Size(200, 25))
    let lblCategory = new Label(Text = "Category:", Location = Point(20, 60), AutoSize = true)
    let txtCategory = new TextBox(Location = Point(120, 60), Size = Size(200, 25))
    let lblType = new Label(Text = "Type:", Location = Point(20, 100), AutoSize = true)
    let cmbType = new ComboBox(Location = Point(120, 100), Size = Size(200, 25), DropDownStyle = ComboBoxStyle.DropDownList)
    cmbType.Items.AddRange([| "Income"; "Expense" |])
    let btnAddTransaction = new Button(Text = "Add Transaction", Location = Point(20, 140), Size = Size(150, 30))
    let lstTransactions = new ListBox(Location = Point(20, 200), Size = Size(820, 200))
    lstTransactions.Font <- new Font("Arial", 10.0F)

    // Add transaction button logic
    btnAddTransaction.Click.Add(fun _ ->
        match Decimal.TryParse(txtAmount.Text), txtCategory.Text.Trim(), cmbType.SelectedItem with
        | (true, category, selectedType) when category <> "" && selectedType <> null ->
            transactions.Add({ Amount = Decimal.Parse(txtAmount.Text); Category = category; Type = selectedType.ToString() })
            updateListBox lstTransactions (transactions |> Seq.map (fun t -> $"Amount: {t.Amount}, Type: {t.Type}, Category: {t.Category}"))
            txtAmount.Clear()
            txtCategory.Clear()
            cmbType.SelectedIndex <- -1
            showMessage "Transaction added!"
        | _ -> showMessage "Invalid input! Please complete all fields."
    )

    tabExpenses.Controls.AddRange([| lblAmount; txtAmount; lblCategory; txtCategory; lblType; cmbType; btnAddTransaction; lstTransactions |])

    // **Budgeting Tab**
    let tabBudget = new TabPage(Text = "Budgeting")
    tabBudget.BackColor <- Color.LightGray
    let lblBudgetCategory = new Label(Text = "Category:", Location = Point(20, 20), AutoSize = true)
    let txtBudgetCategory = new TextBox(Location = Point(120, 20), Size = Size(200, 25))
    let lblBudgetAmount = new Label(Text = "Budget Amount:", Location = Point(20, 60), AutoSize = true)
    let txtBudgetAmount = new TextBox(Location = Point(120, 60), Size = Size(200, 25))
    let btnSetBudget = new Button(Text = "Set Budget", Location = Point(20, 100), Size = Size(150, 30))
    let lstBudgets = new ListBox(Location = Point(20, 140), Size = Size(820, 200))
    lstBudgets.Font <- new Font("Arial", 10.0F)

    // Set budget button logic
    btnSetBudget.Click.Add(fun _ ->
        match Decimal.TryParse(txtBudgetAmount.Text), txtBudgetCategory.Text.Trim() with
        | (true, category) when category <> "" ->
            budgets.Add({ Category = category; Limit = Decimal.Parse(txtBudgetAmount.Text) })
            updateListBox lstBudgets (budgets |> Seq.map (fun b -> $"Category: {b.Category}, Limit: {b.Limit}"))
            txtBudgetCategory.Clear()
            txtBudgetAmount.Clear()
            showMessage "Budget added!"
        | _ -> showMessage "Invalid input! Please complete all fields."
    )

    tabBudget.Controls.AddRange([| lblBudgetCategory; txtBudgetCategory; lblBudgetAmount; txtBudgetAmount; btnSetBudget; lstBudgets |])

    // **Savings Goals Tab**
    let tabSavings = new TabPage(Text = "Savings Goals")
    tabSavings.BackColor <- Color.LightGray
    let lblGoalName = new Label(Text = "Goal Name:", Location = Point(20, 20), AutoSize = true)
    let txtGoalName = new TextBox(Location = Point(120, 20), Size = Size(200, 25))
    let lblTargetAmount = new Label(Text = "Target Amount:", Location = Point(20, 60), AutoSize = true)
    let txtTargetAmount = new TextBox(Location = Point(120, 60), Size = Size(200, 25))
    let lblCurrentAmount = new Label(Text = "Current Savings:", Location = Point(20, 100), AutoSize = true)
    let txtCurrentAmount = new TextBox(Location = Point(120, 100), Size = Size(200, 25))
    let btnSaveGoal = new Button(Text = "Save Goal", Location = Point(20, 140), Size = Size(150, 30))
    let lstSavingsGoals = new ListBox(Location = Point(20, 200), Size = Size(820, 200))
    lstSavingsGoals.Font <- new Font("Arial", 10.0F)

    // Save goal button logic
    btnSaveGoal.Click.Add(fun _ ->
        match Decimal.TryParse(txtTargetAmount.Text), Decimal.TryParse(txtCurrentAmount.Text), txtGoalName.Text.Trim() with
        | (true, true, name) when name <> "" ->
            savingsGoals.Add({ Name = name; Target = Decimal.Parse(txtTargetAmount.Text); Current = Decimal.Parse(txtCurrentAmount.Text) })
            updateListBox lstSavingsGoals (savingsGoals |> Seq.map (fun g -> $"Goal: {g.Name}, Target: {g.Target}, Current: {g.Current}"))
            txtGoalName.Clear()
            txtTargetAmount.Clear()
            txtCurrentAmount.Clear()
            showMessage "Savings goal added!"
        | _ -> showMessage "Invalid input! Please complete all fields."
    )

    tabSavings.Controls.AddRange([| lblGoalName; txtGoalName; lblTargetAmount; txtTargetAmount; lblCurrentAmount; txtCurrentAmount; btnSaveGoal; lstSavingsGoals |])

    // Add tabs to control
    tabControl.TabPages.AddRange([| tabExpenses; tabBudget; tabSavings |])
    form.Controls.Add(tabControl)
    form

// Application Entry Point
[<EntryPoint>]
let main argv =
    let mainForm = createMainForm()
    Application.Run(mainForm)
    0
