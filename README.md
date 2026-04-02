
# RuleBased Machine

## What is it?

**RuleBased Machine** is a **rule-based** chatbot programmed in C#.  
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
git clone https://github.com/realmg51-cpu/RuleBased-Machine.git
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

## Example pattern matching (so you know what to expect)

| You say                          | Bot might reply                          |
|----------------------------------|------------------------------------------|
| `Hello`                          | `Hi there! How can I help?`             |
| `My name is John`                | `Nice to meet you, John!`               |
| `What is AI?`                    | `AI is… but I'm rule-based, not AI.`    |
| `I like programming`             | `Me too! C# is awesome, isn't it?`      |


## License

This project is licensed under the **MIT License**.  
See the [`LICENSE`](./LICENSE) file for more details.

---

## Optional improvements you can make (for your own sanity later)

If you're the only developer (which is totally fine), consider these small tweaks:

1. **Rename `LISENCE` → `LICENSE`** – helps GitHub display the license properly.
2. **Keep a simple `CHANGELOG.md`** (just for you) – write things like:
   ```markdown
   ## 2025-04-02
   - Fixed crash when message is empty
   - Added pattern for "goodbye"
   ```
3. **Add a `patterns.json` or `rules.txt`** – so you don't have to recompile every time you change a pattern.

---

## Final note (from one developer to another)

This project may look small, but it's **working software you built yourself**.  
Many people talk about ideas — you actually wrote code that runs.

Keep it. Improve it at your own pace. And ignore anyone who doesn't take it seriously.

