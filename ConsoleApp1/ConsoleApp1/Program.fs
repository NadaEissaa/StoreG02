// Define the data types for the application
type Transaction = {
    Amount: decimal
    TransactionType: string // Can be "Income" or "Expense"
    Category: string
}

type Budget = {
    Category: string
    Amount: decimal
}

type SavingsGoal = {
    GoalName: string
    TargetAmount: decimal
    CurrentAmount: decimal
}

// List to hold transactions
let mutable transactions = []

// Function to add a transaction
let addTransaction (transaction: Transaction) =
    transactions <- transaction :: transactions

// Function to filter transactions by category
let filterByCategory (category: string) =
    transactions |> List.filter (fun t -> t.Category = category)

// Function to display transactions
let displayTransactions (transactions: Transaction list) =
    transactions |> List.iter (fun t -> 
        printfn "Amount: %.2f, Type: %s, Category: %s" t.Amount t.TransactionType t.Category)

// Function to calculate total expenses for a specific category
let calculateTotalExpenses (category: string) =
    transactions 
    |> List.filter (fun t -> t.Category = category && t.TransactionType = "Expense")
    |> List.sumBy (fun t -> t.Amount)

// Function to check budget usage for a specific category
let checkBudgetUsage (category: string) (budget: Budget) =
    let total = calculateTotalExpenses category
    if total > budget.Amount then
        printfn "Budget exceeded for %s: Total Expense = %.2f, Budget = %.2f" category total budget.Amount
    else
        printfn "Budget for %s is within limits: Total Expense = %.2f, Budget = %.2f" category total budget.Amount

// Function to recommend monthly savings to meet a savings goal
let recommendSavings (goal: SavingsGoal) =
    let remainingAmount = goal.TargetAmount - goal.CurrentAmount
    if remainingAmount > 0m then
        printfn "You need to save %.2f per month to reach your goal of %.2f" (remainingAmount / 12m) goal.TargetAmount
    else
        printfn "You have already met your savings goal for %s!" goal.GoalName

// Example usage
let _ =
    // Add transactions
    addTransaction { Amount = 50M; TransactionType = "Expense"; Category = "Food" }
    addTransaction { Amount = 100M; TransactionType = "Income"; Category = "Salary" }
    addTransaction { Amount = 30M; TransactionType = "Expense"; Category = "Food" }

    // Display all transactions
    printfn "All Transactions:"
    displayTransactions transactions

    // Filter and display food-related transactions
    let foodTransactions = filterByCategory "Food"
    printfn "\nFood Transactions:"
    displayTransactions foodTransactions

    // Budgeting Example
    let foodBudget = { Category = "Food"; Amount = 100M }
    checkBudgetUsage "Food" foodBudget

    // Savings Goal Example
    let vacationGoal = { GoalName = "Vacation"; TargetAmount = 5000M; CurrentAmount = 1000M }
    recommendSavings vacationGoal
