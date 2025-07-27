# PhoneKeypadApp

A simple C# console application that decodes strings simulating input from old mobile phone keypads (like T9 predictive text input). It maps numeric key presses to characters and supports special operations like backspace and end-of-input.

---

## How It Works

Each digit (e.g., `2`) corresponds to a group of letters (e.g., `ABC`). The number of presses on a key determines the character selected.

### Supported Special Characters:
- ` ` (space) – Confirms the selected character.
- `*` – Backspace (removes the last character).
- `#` – Ends input.

---

## Example

| Input | Output |
|-------|--------|
| `33#` | E      |
| `227*#` | B    |
| `4433555 555666#` | HELLO |
| `8 88777444666*664#` | TURING |

---

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/htetnaing-hub/Code-Challenge.git
cd PhoneKeypadApp
```
### 2. Build the Project

```bash
dotnet build
```

### 3. Run the App

```bash
dotnet run
```
---

## Unit Tests

### 1. Clone the Repository of Unit Test

```bash
git clone https://github.com/htetnaing-hub/Code-Challenge-Unit-Test.git
cd PhoneKeypadApp.Tests
```
### 2. Run Unit Test

```bash
dotnet test
```
---

## Documentation

### 1. Generate API documentation using DocFX

```bash
docfx metadata
docfx build
docfx serve
```

### 2. Visit the following URL

```bash
http://localhost:8080
```

---

## Technologies Used

- C# .NET 8
- Console Application
- Dictionary-based mapping
- `Optional` DocFX for documentation

---

## Author

### Created by Htet Naing Aung

---




