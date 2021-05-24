# C# katas

`Katas.sln` contains two projects - `KatasProject` and `Test`. `KatasProject` contains both the methods you need to complete (`Katas.cs`) and a few classes that are used by those methods (`Models.cs`).

`Test` contains `KatasTest` - where you'll be writing your unit tests in Day 2. Unit tests for Day 1 katas have been provided.

## Day 1 - Base Katas

### MultiplyNums
Returns the product of two numbers.

### CalculateDivisors
The challenge is to implement a method which adds all the multiples of three and five **below** the given number.
If we list all the numbers below 12 that are multiples of 3 or 5, we get 3, 5, 6, 9 and 10. The sum of these multiples is 33.

### Fibonacci
Returns the Fibonacci number for given number.
The fibonacci formula is `Fn` = `Fn-1` + `Fn-2`
```cs
Fibonacci(0) // 0
Fibonacci(1) // 1
Fibonacci(2) // 1
Fibonacci(3) // 2
Fibonacci(4) // 3
Fibonacci(5) // 5
```

### PigLatin
Returns a sentence translated into Pig Latin

To translate to [Pig Latin](https://en.wikipedia.org/wiki/Pig_Latin) you take the first consonant (or consecutive consonants) of each word, move it to the end and also append 'ay'. If the word starts with a vowel, just append 'way' at the end.

```cs
PigLatin("northcoders");
// should return 'orthcodersnay'
```

```cs
PigLatin("sheffield");
// should return 'effieldshay'
```

```cs
PigLatin("algorithm");
// should return 'algorithmway'
```

```cs
PigLatin("keep on coding");
// should return 'eepkay onway odingcay'
```

### SumArgs
Returns the sum of zero or more numbers. When passed no numbers returns 0.

### CounterSpy
Given a List of Agents removes all spies. A spy is an agent who's name contains `'s'`, `'p'` _or_ `'y'`. The method returns a list with only the loyal agents.

### AreCatsDominant
Takes a mixed list of Animals - Dogs and Cats. Return `true` if most are cats, `false` if most are dogs, `null` if equal.

### EvolvePokemon
Given a `Diglett` returns a `Dugtrio` with it's Level property increased by `1`.

### HeroCareerChange

In this kata you will be working with 4 classes `Villager`, `Hero`, `Druid`, `Mage`. `Villager` is the base class and the others are derived from it.
Given a hero determine what career they are best suited for. There is a private method in `Katas.cs` which takes a _Villager_ and returns a string representing their destiny (either "Druid" or "Mage").
After casting to the appropriate class return the string property `BattleCry` from the new class.

## Day 2 - testing

Practice unit testing by solving the following katas using Test Driven Development.

### CheckHeight
Take a Person and check if their height is over 155cm.

### ConvertToSassCase
Takes a string, returns a sassy version of the string (alternating lower/upper case characters)
e.g. `thanks for the coffee` gets turned into `tHaNkS FoR ThE CoFfEe`.

### TwitterFeedAnalysis
Takes a collection of strings, checks each string for any mentions (strings starting with `@`) + hashtags (strings starting with `#`), returns a dictionary of mentions + hashtags with a count
e.g. a single string `@nintendo when's the next zelda coming out?` returns a dictionary with `<"@nintendo", 1>` as the only key/value pair.
e.g. two strings `going through a baking phase #bread + #bagels`, `lunchtime! #bagels` returns a dictionary with `<"#bread", 1>`  and `<"#bagels", 2>` key/value pairs.

### CategoriseCustomerIds
Takes a list of customers and a list of Guids (unique ids), returns a dictionary of categorised customer ids.
`deprecated`: customer ids that are not Guids
`current`: customer ids that exist in the currentGuids list
`legacy`: customer ids that aren't in the currentGuids list

### TriageArtworks
Takes a list of artwork submissions and a cut-off date, returns an array of the first three to be submitted on time.

### UpdateUserNotes
Takes a collection of users and a collection of notes, returns a list of users with their notes updated where the `Id` of a note matches an the `Id` of a note belonging to a user.
```cs
Users [
	{
	 Id : Guid 123,
	 Name: "doug",
	 Notes: [
	  {Id: Guid 1, Value: "buy fruit"},
	  {Id: Guid 2, Value: "hug animals"}
	 ]
	}
]

updatedNotes [
  {Id: Guid 1, Value: "sell vegetables"}
]

/// becomes
Users [
	{
	 Id : Guid 123,
	 Name: "doug",
	 Notes: [
	  {Id: Guid 1, Value: "sell vegetables"},
	  {Id: Guid 2, Value: "hug animals"}
	 ]
	}
]
```

## Day 2 - LINQ

To explore the flexibility LINQ provides, solve the katas located in Linq.cs. Tests are provided for these. Aim to find the most appropriate LINQ syntax. To help you with this, you can always refer to the methods listed on the left hand side https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.aggregate?view=net-5.0.

### GetLargestNum

Return the largest int in the list. Return zero if the list is empty.

### GetFirstPerson

Return the first person in the list. Return null if the list is empty.

### GetFirstPersonOver

Return the first person in list who is above a given height. Return null if there's no match.

### GetPersonByFirstName

Return the only person with a given name. Return null if none/multiple found.

### CheckIfPersonExists

Return a boolean to indicate if there is at least one person with this name.

### GetSurnames

Return the surnames of all people.

### GetAllFirstNamesOfFamilyMembers

Return the first names of all people with a given surname.

### OrderPeopleByHeight

Return the people ordered by their height ascending.

### CalculateAverageHeight

Return average height of people. Return 0 if empty.

### PersonDictionary

Return a dictionary of id/"firstName+surname" key/value pairs.

### CheckAllPeopleTallEnough

Return a boolean that tell us if all people are over a certain height.

### GetFirstOfEachFamily

Return people de-duplicated by surname. 

### GroupIntoFamilies

Return people grouped by surname.

### GenerateHashSetOfIds

Return a hashset of ids given a List of people.

### MergeAndDedupe

Given two lists of integers, return one list of the unique numbers found in both arrays. 

## Day 2 - LINQ + Testing

Now you are more comfortable with the LINQ syntax, implement the following katas found in LinqExtras.cs using TDD.

### BuildStringFromInitials

Return a single string made up of the first character of each first name + surname.

### AverageHeights

Return a dictionary of surname + avg height of all people with that surname.

### TallestFamilyMembers

Return the ids of the tallest member of each family.

### DominantFamily

Return the most common surname in the list. If there's a draw between two surnames, return the surname that has the most characters in all of the first names.

### Flatten

Return a flattened List of integers from a nested List with one level of nesting (though the parent List can have multiple nested Lists).


