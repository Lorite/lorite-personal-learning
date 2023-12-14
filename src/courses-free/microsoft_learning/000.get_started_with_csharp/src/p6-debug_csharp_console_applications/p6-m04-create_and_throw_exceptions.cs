using System;
using System.Linq;

namespace Lorite.GetStartedWithCSharp.P6M04CreateAndThrowExceptions {

    public static class Program {

        public static void Main() {
            // Exceptions can be thrown by your code when an issue or error condition is encountered. Exception objects that describe an error are created and then thrown with the throw keyword.
            // When an exception is thrown by your code, the runtime searches for the nearest catch clause that can handle the exception.
            // Here are some common exception types that you might use when creating an exception: System.ArgumentException, System.ArgumentNullException, System.ArgumentOutOfRangeException, System.DivideByZeroException,
            // System.FormatException, System.IndexOutOfRangeException, System.InvalidCastException, System.InvalidOperationException, System.IO.IOException, System.NotImplementedException, System.NullReferenceException,
            // System.OutOfMemoryException, System.OverflowException, System.StackOverflowException, System.TypeInitializationException, System.TypeLoadException, System.TypeUnloadedException, System.UnauthorizedAccessException

            // Example
            try {
                OperatingProcedure1();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exiting application.");
            }

            static void OperatingProcedure1() {
                string[][] userEnteredValues = new string[][] {
                    new string[] { "1", "two", "3"},
                    new string[] { "0", "1", "2"}
                };

                foreach(string[] userEntries in userEnteredValues) {
                    try {
                        BusinessProcess1(userEntries);
                    } catch (Exception ex) {
                        if (ex.StackTrace.Contains("BusinessProcess1")) {
                            if (ex is FormatException) {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Corrective action taken in OperatingProcedure1");
                            } else if (ex is DivideByZeroException) {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                                // re-throw the original exception
                                throw;
                            } else {
                                // create a new exception object that wraps the original exception
                                throw new ApplicationException("An error occurred - ", ex);
                            }
                        }
                    }

                }
            }

            static void BusinessProcess1(String[] userEntries) {
                int valueEntered;

                foreach (string userValue in userEntries) {
                    try {
                        valueEntered = int.Parse(userValue);

                        checked {
                            int calculatedValue = 4 / valueEntered;
                        }
                    }
                    catch (FormatException) {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    } catch (DivideByZeroException) {
                        DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
                        throw unexpectedDivideByZeroException;

                    }
                }
            }

            // Things to avoid when throwing exceptions
            // Don't use exceptions to change the flow of a program as part of ordinary execution. Use exceptions to report and handle error conditions.
            // Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
            // Don't throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
            // Don't create exceptions that can be thrown in debug mode but not release mode. To identify runtime errors during the development phase, use Debug.Assert instead.

            // When creating and throwing an exception, the exception type must match the intended purpose of the exception as closely as possible.
            // To throw an exception, you create an instance of an exception-derived class, configure its properties, and then use the throw keyword.
            // When creating an exception object, it's important to provide clear error messages and additional information to help users correct the issue.

            // Exercise
            string[][] userEnteredValues = new string[][] {
                        new string[] { "1", "2", "3"},
                        new string[] { "1", "two", "3"},
                        new string[] { "0", "1", "2"}
            };

            try {
                Workflow1(userEnteredValues);
                Console.WriteLine("'Workflow1' completed successfully.");

            } catch (DivideByZeroException ex) {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(ex.Message);
            }

            static void Workflow1(string[][] userEnteredValues) {
                foreach (string[] userEntries in userEnteredValues) {
                    try {
                        Process1(userEntries);
                        Console.WriteLine("'Process1' completed successfully.");
                        Console.WriteLine();
                    } catch (FormatException ex) {
                        Console.WriteLine("'Process1' encountered an issue, process aborted.");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }
                }
            }

            static void Process1(String[] userEntries) {
                int valueEntered;

                foreach (string userValue in userEntries) {
                    bool integerFormat = int.TryParse(userValue, out valueEntered);

                    if (integerFormat == true) {
                        if (valueEntered != 0) {
                            checked {
                                int calculatedValue = 4 / valueEntered;
                            }
                        } else {
                            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                        }
                    } else {
                        throw new FormatException("Invalid data. User input values must be valid integers.");
                    }
                }
            }

        }

    }

}