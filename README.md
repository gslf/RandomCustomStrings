# RandomCusomStrings
## Ultralight customizable random string generator



## Overview
The `RandomCustomStrings` class in the `Promezio.RandomCustomStrings` namespace provides a simple yet flexible way to generate random strings in C#. This can be highly useful in scenarios like generating random IDs, passwords, test data, and more. The class allows for extensive customization through the `StringConfig` class, enabling users to specify the length and character types of the generated strings.

## Features
- **Customizable String Length:** Define the length of the generated string.
- **Character Type Inclusion:** Opt to include uppercase, lowercase, numbers, special characters, and/or custom characters in the string.
- **Custom Character Support:** Add any set of custom characters to the string generation pool.

## Usage
1. **Add Namespace:** Include the namespace in your code.
   ```csharp
   using Promezio.RandomCustomStrings;
   ```

2. **Create Configuration:** Instantiate a `StringConfig` object with your desired settings.
   ```csharp
   StringConfig config = new StringConfig(
       lenght: 10, 
       containUppercase: true, 
       containLowercase: true, 
       containNumbers: true, 
       containSpecialChars: true
   );
   ```

3. **Generate String:** Use the `Generate` method to create a random string.
   ```csharp
   string randomString = RandomCustomStrings.Generate(config);
   ```

## Example
```csharp
StringConfig config = new StringConfig(15, containUppercase: true, containNumbers: true);
string myRandomString = RandomCustomStrings.Generate(config);
Console.WriteLine(myRandomString);
```

## Included seeds
```csharp
uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
lowercase = "abcdefghijklmnopqrstuvwxyz";
numbers = "0123456789";
specialChars = ",.;:-_*()%$&?!=/";
```

## Use custom characters
```csharp
 StringConfig config = new StringConfig(10,
         customChars: "@£\|",
         containCustomChars: true);

 string randomString = RandomCustomStrings.Generate(config);
```

## Contribution
Feel free to fork this project, submit pull requests, or report bugs and feature requests on the issue tracker.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

---
Coded by [Gioele Stefano Luca Fierro](https://www.gslf.it)

Sponsored by [Promezio](https://www.promezio.it)
