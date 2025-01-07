
# **Expense Manager**

The **Expense Manager** is a simple console-based application built using .NET that allows users to retrieve, filter, and display expense data stored in `.txt` or `.json` file formats. The application enables users to filter expenses by category or date range and provides an intuitive user interface to manage and view their expenses.

## **Features**
- **Read Expense Data**: The application can read expense data from `.txt` and `.json` files.
- **Display Expenses**: Expenses are displayed in a tabular format with clear columns for date, category, amount, and description.
- **Filter by Category**: Filter expenses by category (e.g., Food, Transport, etc.).
- **Filter by Date Range**: Filter expenses within a specified start and end date.
- **Error Handling**: Graceful error handling for missing files, unsupported formats, and invalid inputs.
- **Currency Formatting**: Amounts are formatted according to the specified culture (e.g., USD).

## **Getting Started**

### Prerequisites

- **.NET SDK**: The application is built using .NET, so you'll need to have the .NET SDK installed on your system. You can download it from [here](https://dotnet.microsoft.com/download).
- **Text or JSON File**: The application expects a file containing expense data in `.txt` or `.json` format.

### Installation

1. Clone or download this repository.
2. Open the project in your preferred IDE (e.g., Visual Studio, Visual Studio Code).
3. Restore the required dependencies by running:

   ```bash
   dotnet restore
   ```

### Running the Application

1. Build and run the application:

   ```bash
   dotnet run
   ```

2. When prompted, enter the file path of your expense data file (either `.txt` or `.json` format).

### File Format

- **.txt File Format**:
  Each line in the text file should represent a single expense entry, with the following comma-separated fields:  
  `Date, Category, Amount, Description`

  Example:
  ```txt
  2025-01-05, Food, 15.00, Lunch at cafe
  2025-01-06, Transport, 10.00, Bus fare to work
  ```

- **.json File Format**:
  The JSON file should contain an array of expense objects with properties: `Date`, `Category`, `Amount`, and `Description`.

  Example:
  ```json
  [
    {
      "Date": "2025-01-05",
      "Category": "Food",
      "Amount": 15.00,
      "Description": "Lunch at cafe"
    },
    {
      "Date": "2025-01-06",
      "Category": "Transport",
      "Amount": 10.00,
      "Description": "Bus fare to work"
    }
  ]
  ```

### Menu Options

Once the expense data is successfully loaded, the program will display a menu with the following options:

1. **Filter by Category**: Allows you to filter expenses by category (e.g., Food, Transport).
2. **Filter by Date Range**: Allows you to filter expenses by a specified date range.
3. **Return to Main Menu**: Returns to the main menu to choose another action.
4. **Exit**: Exits the program.

### Example Usage

1. **Enter the file path** when prompted:
   ```
   D:\ExpenseData\expenses.json
   ```

2. **Viewing Expenses**:
   ```
   Date       | Category      | Amount   | Description
   ----------------------------------------------------
   2025-01-05 | Food          | $15.00   | Lunch at cafe
   2025-01-06 | Transport     | $10.00   | Bus fare to work
   ```

3. **Filter by Category**: Enter `1` to filter by category, then provide the category name (e.g., `Food`).
   
4. **Filter by Date Range**: Enter `2` to filter by date range, then input the start and end dates (e.g., `2025-01-05` and `2025-01-06`).

### Error Handling

- If the file does not exist, an error message will be displayed.
- If the file format is unsupported, an error message will be displayed.
- Invalid menu choices or filter inputs will prompt the user to try again.

## **File Structure**

The project consists of the following classes:
- **Expense**: A model class to represent an individual expense.
- **ExpenseDisplay**: A class responsible for displaying expenses and providing the menu for user interaction.
- **FileHandler**: A class responsible for reading expense data from `.txt` and `.json` files.

## **License**

This project is open-source and available under the MIT License.

---

