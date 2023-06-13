# Exponentially-increasing-nested-loops

This is a C# console application that demonstrates the evaluation of a function with varying dimensions using different step sizes. The program finds the maximum value of the function within a given range for each dimension.

## Getting Started

To run the application, you need to have a C# compiler or an integrated development environment (IDE) such as Visual Studio. Simply copy the code into a C# project, compile it, and execute the resulting executable.

## Description

The program evaluates a function with up to five dimensions and determines the maximum value within the range [0, 10] for each dimension. The step size for each dimension is provided as a parameter to the respective function.

The `T1`, `T2`, `T3`, `T4`, and `T5` functions evaluate the function for one to five dimensions, respectively. The `func` function defines the mathematical function being evaluated, which sums the sine of each dimension's value.

The `printres` function is responsible for displaying the results, including the dimension, delta size, maximum value, and the corresponding values of each dimension.

## Usage

1. Compile and run the application.
2. The program will evaluate the function for each dimension and display the results.
3. The delta size represents the step size used for each dimension.
4. The maximum value and corresponding dimension values are printed for each dimension.

## Example Output

```
1       2       3       4       5
---------------------------------------
Delta Size = 0.1         X_Max = 1.0      FxMax = 0.620167037783394
Delta Size = 0.01        X_Max = 0.99     FxMax = 0.620167040992172
Delta Size = 0.001       X_Max = 0.999    FxMax = 0.620167040825758
```

## License

This project is licensed under the [MIT License](LICENSE.md). Feel free to use, modify, and distribute the code for personal or commercial purposes.

## Contact

For any inquiries or questions, please contact [karimika13.ka@gmail.com].

Thank you for using the Exponentially-increasing-nested-loops!
