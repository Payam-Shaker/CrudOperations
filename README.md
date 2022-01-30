# crud-payam NuGet Package

This is a class library which facilitates easier CRUD operations against EF-databases using a generic class which accepts any type, available at:
https://www.nuget.org/packages/crud-payam/1.0.3

## Installation

Use the package manager in Visual Studio to install crud-payam or use the package-manager window.
```
install-package crud-payam
```

## Usage

Full implementation of this class library can be found in public repository AdventureWorksInventory which is a MVC .NET Core 3.1 address book management application, using Microsoft's sample AdventureWorksLT2019: https://github.com/Payam-Shaker/AdventureWorksInventory

After declaring relevant namespace in the controller, where CRUD operations is expected to run to show the appropriate result in the view, a new instance of Crud class can be created. The object specific to that controller can be passed into this new instance where originally a T, i.e. generic object type is expected. Database context of the application must also be passed as argument.
Methods that conduct CRUD operations, namely GetById() / Update() / Edit () / Delete() can be called through this new instance.

```cs
using CrudOperations;


        public IActionResult Index(int id)
        {
            var context = new Crud<Address>(_dbcontext);
            var result = context.GetById(id);
            return View(result);
        }
```

## Source code
You can find the code on my [Github](https://github.com/Payam-Shaker/CrudOperations) account.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[Apache 2](https://tldrlegal.com/license/apache-license-2.0-%28apache-2.0%29)
