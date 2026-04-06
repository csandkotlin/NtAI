
# Not A AI (NtAI)
[![.NET Core Desktop](https://github.com/csandkotlin/NtAI/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/csandkotlin/NtAI/actions/workflows/dotnet-desktop.yml)
[![.NET Core Desktop](https://github.com/csandkotlin/NtAI/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/csandkotlin/NtAI/actions/workflows/dotnet-desktop.yml)

---
[Đọc tiếng việt đi bro](./README_VI.md)
## What is it?

**NtAI** is a **rule-based** chatbot programmed in C#.  
It uses **pattern matching** to understand and respond to user messages — no AI, no machine learning, just simple and predictable logic.

> Perfect for learning, prototyping, or embedding into tools where deterministic responses are enough.

## How to use

Type your message, and the chatbot will reply by matching your input against predefined patterns.

## Clone and build it yourself

### Requirements

- **Git** – for cloning the repository  
- **.NET SDK** – minimum version **8.0** (to build and run)

### Steps

**1. Clone this repository**

```bash
git clone https://github.com/csandkotlin/NtAI.git
```

**2. Build the project**

```bash
cd src/main
dotnet build
```


**3. Run (optional)**

```bash
dotnet run
```

## Example pattern matching

| You say                          | Bot might reply                          |
|----------------------------------|------------------------------------------|
| `Hello`                          | `Hi there! How can I help?`             |
| `What is AI?`                    | `AI is… but I'm rule-based, not AI.`    |
| `I like programming`             | `Me too! C# is awesome, isn't it?`      |


## License

This project is licensed under the **MIT License**.  
See the [`LICENSE`](./LICENSE) file for more details.

---


