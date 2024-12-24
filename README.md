# README: Employee Salary Calculation Backend

## Project Overview
This project is a simple C# console application designed to calculate an employee's salary based on their weekly working hours and hourly rate. It includes functionality to calculate overtime pay at 1.5 times the standard rate for hours worked over 40 hours in a week.

## Features
1. **Input Validation**
   - Prompts the user to enter the total hours worked in a week and the hourly rate.
   - Ensures valid numeric input to avoid runtime errors.

2. **Salary Calculation**
   - Calculates the total salary based on the following logic:
     - Regular hours (up to 40) are paid at the standard hourly rate.
     - Overtime hours (above 40) are paid at 1.5 times the standard hourly rate.

3. **Error Handling**
   - Handles invalid input gracefully by displaying appropriate error messages.

## File Structure
```
TesBackend/
|-- Program.cs
|-- TesBackend.csproj
```

## Getting Started

### Prerequisites
- .NET SDK installed. You can download it from [Microsoft .NET](https://dotnet.microsoft.com/download).

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/theochristians/TestBackend.git
   cd TesBackend
   ```

2. Open the project in Visual Studio or your preferred IDE.

### Running the Program
1. Open a terminal or use the IDE's integrated terminal.
2. Run the application using the following command:
   ```bash
   dotnet run
   ```

3. Follow the prompts to enter the hours worked and hourly rate. The application will calculate and display the total salary.

## Example Usage
### Input
```
Masukkan jumlah jam kerja dalam seminggu: 50
Masukkan tarif per jam: 50000
```

### Output
```
Total gaji karyawan: Rp 2750000.00
```

## How It Works
1. The program prompts the user for the following inputs:
   - **Weekly Hours Worked:** Total hours worked in a week.
   - **Hourly Rate:** Payment per hour.

2. The `HitungGaji` method processes the inputs:
   - If the hours worked are more than 40, it calculates overtime pay.
   - Otherwise, it calculates the salary based on regular hours only.

3. The calculated salary is displayed to the user in a formatted string.

## Code Explanation
### Main Method
The `Main` method handles user input, error handling, and displays the result.

### HitungGaji Method
This method contains the salary calculation logic:
- Calculates overtime pay for hours exceeding 40.
- Adds regular pay and overtime pay to compute the total salary.

## Error Handling
- **FormatException**: Catches invalid input (e.g., non-numeric values).
- **Generic Exception**: Handles unexpected errors and displays an appropriate message.

## Customization
- Adjust the overtime multiplier in the `HitungGaji` method if needed.
- Update the input/output messages for localization or additional features.

## Contribution
Contributions are welcome! Feel free to open issues or submit pull requests.

## License
This project is licensed under the MIT License.

![image](https://github.com/user-attachments/assets/1f8c642f-ac17-4f8f-a686-eed662ab0667)
