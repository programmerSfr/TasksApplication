# TasksApplication

TasksApplication is a C# .NET Core application for customizations.


## Usage

Get the code using a Git client.

```bash
$ git clone https://github.com/programmerSfr/TasksApplication.git
```

Using the service provided

```c#
using entityservice;

# returns maximum product of an integer array
entityservice.Calcs calcs = new entityservice.Calcs();

# returns (int, int, int) => (product, firstValue, secondValue)
int[] numbersArr = {6,7,2,1};
int multipleOf = 3;
(int, int, int) result = calcs.GetMaximumProductMultiple(numbersArr, multipleOf);

```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
