# Artilities.ArtilitiesClient()
## This is a seperated documentation file written for the Artilities.ArtilitiesClient()
- This file contains every Artilities.ArtilitiesClient() function / method nicely wrapped up
- In case some values turn out like "??? ?? ????", set your output encoding to UTF-8 (Console-App Example: `Console.OutputEncoding = System.Text.Encoding.UTF8;`)

<details>
<summary>ArtilitiesClient</summary>
<p>The Artilities.ArtilitiesClient() Object is a crucial part to interact with the Artilities API, as there needs to be an instance of it to work.</p>

### Values:
- ignoreNonOK : bool (default: false) : If turned to true, the library will not throw Exceptions on Non-HttpOK responses
### Example:
```CSharp
Artilities.ArtilitiesClient artClient = new Artilities.ArtilitiesClient(); // We will use this ArtilitiesClient for the rest of the examples
```

### Returns: 
- Nothing
</details>

<details>
<summary>GetIdea()</summary>
<p>This function allows you to retrieve an Artilities Art-Idea</p>

### Example:
```CSharp
var Idea = artClient.GetIdea();
Console.WriteLine($"My Art Idea: {Idea.english}");
```

### Returns:
- Artilities.Objects.DefaultResponse
</details>

<details>
<summary>GetChallenge()</summary>
<p>This function allows you to retrieve an Artiltiies Art-Challenge</p>

### Example:
```CSharp
var Challenge = artClient.GetChallenge();
Console.WriteLine($"My Art Challenge: {Challenge.english}")
```

### Returns:
- Artilities.Objects.DefaultResponse
</details>

<!--- JUST A TEMPLATE

<details>
<summary></summary>
<p></p>

### Required Values:

### Example:
```CSharp
```

### Returns:
</details>
--->
