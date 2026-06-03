
https://github.com/user-attachments/assets/50bba787-f958-4bce-9f73-afae2566eea6


# Flappy Bird Clone

> A faithful recreation of the classic Flappy Bird arcade game, built in Unity with C#.

[![Unity](https://img.shields.io/badge/Unity-2D-black?logo=unity)](https://unity.com/)
[![Language](https://img.shields.io/badge/Language-C%23-239120?logo=csharp)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Status](https://img.shields.io/badge/Status-Complete-brightgreen)]()

---

## Overview

**Flappy Bird Clone** is a 2D arcade game built in Unity using C#. The player taps to keep the bird airborne while navigating through an endless stream of pipes — one hit and it's game over.

A self-contained project built to practice Unity 2D fundamentals: physics, collision detection, procedural object spawning, and game state management.

---

## Gameplay

- Tap `Space` (or click) to flap
- Clear gaps between pipes to survive
- Collide with a pipe or the ground — game over
- Press `Space` or click to restart

---

## Features

- 🐦 Physics-based bird movement using Unity's Rigidbody2D
- 🌿 Endless pipe generation with randomised gap positions
- 💥 Collision detection with game over screen
- 🔁 Instant restart without reloading the scene
- 📱 Simple one-button input (keyboard + mouse)

---

## Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download) installed
- Unity **2022.3 LTS** or newer

### Installation

```bash
# 1. Clone the repository
git clone https://github.com/diivyansh1/flappy-bird-clone.git

# 2. Open Unity Hub → Add project → Select the cloned folder

# 3. Open the project in the Unity Editor
```

### Running the Game

1. Open `Assets/Scenes/GameScene` in the Unity Editor
2. Press **Play ▶**

---

## Project Structure

```
flappy-bird-clone/
├── Assets/
│   ├── Scripts/
│   │   ├── BirdController.cs     # Flap physics and input
│   │   ├── PipeSpawner.cs        # Procedural pipe generation
│   │   ├── PipeMove.cs           # Pipe scroll and despawn
│   │   ├── CollisionHandler.cs   # Death and game over logic
│   │   └── GameManager.cs        # State management and restart
│   ├── Scenes/
│   ├── Sprites/
│   └── Prefabs/
├── Packages/
└── ProjectSettings/
```

---

## Controls

| Input | Action |
|---|---|
| `Space` / Left Click | Flap |
| `Space` / Left Click | Restart (on Game Over) |

---

## Built With

- **Unity 2D** — Game engine
- **C#** — Scripting
- **Rigidbody2D** — Bird physics
- **Object Pooling / Instantiate** — Pipe spawning

---

## Author

**Divyanshi** — B.Tech CSE @ Sikkim Manipal Institute of Technology

[![GitHub](https://img.shields.io/badge/GitHub-diivyansh1-181717?logo=github)](https://github.com/diivyansh1)

---

