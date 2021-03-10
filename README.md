# Spire Doc License Test

A test project for licensing the [Spire.Doc](https://www.nuget.org/packages/Spire.Doc/) library.

##  How to Test

* Open the `Startup.cs` file
* Uncomment the lines

    ```csharp
    // LicenseProvider.SetLicenseKey(
    //     "SomeValidKey");
    ```

* Replace `SomeValidKey` with a valid license key
* Run the solution
* The `document` route should be hit
* A file `zzz.pdf` is created in the project root
* This file still shows the evaluation **Evaluation Warning: The document was created with Spire.Doc for .NET.**