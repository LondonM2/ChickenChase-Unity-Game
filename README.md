# Chicken Chase | Unity Game Development

## Project Overview

Chicken Chase is a game development project created using Unity and C# as part of my undergraduate coursework in Web and Digital Design.

The project explores interactive gameplay, game mechanics, object behavior, and programming fundamentals through the Unity game engine.

This project demonstrates my growing experience with C# programming, game development workflows, and interactive digital experiences.

## Technologies Used

- **Unity** — Game development engine
- **C#** — Gameplay programming and scripting
- **Visual Studio** — Code development and debugging
- **Git & GitHub** — Version control and source code management

## Game Development Concepts

Throughout development, I practiced:

- Writing and modifying C# scripts
- Working with Unity GameObjects and components
- Implementing movement and object behavior
- Using variables, methods, and conditional statements
- Working with collision detection and physics
- Testing and troubleshooting gameplay
- Organizing scenes, scripts, and game assets

## Project Structure

- `Assets/` — Game scenes, scripts, textures, models, and other assets
- `Packages/` — Unity package dependencies
- `ProjectSettings/` — Unity project configuration

## Development Process

**1. Planning and Setup**

Established the Unity project environment, reviewed gameplay objectives, and organized the required assets.

**2. Gameplay Development**

Used C# scripting and Unity components to develop interactive game behavior.

**3. Testing and Debugging**

Tested game functionality, identified issues, and adjusted scripts and settings to improve gameplay.

**4. Final Build**

Created a Windows application build to demonstrate the completed project.

## Skills Demonstrated

- C# programming fundamentals
- Unity Editor navigation
- Game mechanics implementation
- Object-oriented programming concepts
- Debugging and problem-solving
- Game asset organization
- Version control with GitHub

## Technical Implementation — C#

### Egg Collection and Game Management

Developed a `ChickenGameManager` script using C# and Unity to manage egg collection, score tracking, and win-condition logic.

Key implementations include:

- **Trigger Detection:** Uses Unity's `OnTriggerEnter()` method and object tags to identify collectible eggs.
- **Score Tracking:** Increments the player's score when an egg is collected.
- **UI Updates:** Dynamically updates the score display using Unity UI Text components.
- **Object Management:** Removes collected eggs from the scene using `Destroy()`.
- **Win Conditions:** Uses conditional statements to determine when the player reaches the required number of eggs and displays a victory message.
- **Configurable Gameplay:** Exposes the required egg count through a public variable, allowing adjustments in the Unity Inspector.

### Programming Concepts Demonstrated

### Collectible Interaction System

The `ChickenCollect.cs` script implements collectible-object interactions using Unity's trigger detection system.

Key programming features include:

- **Trigger Detection:** Uses `OnTriggerEnter()` to detect when another collider enters the collectible's trigger.
- **Tag Validation:** Uses `CompareTag("Player")` to verify that the interacting object is the player.
- **Script Communication:** References the `ScoreManager` component and calls its `AddChicken()` method to update the collection count.
- **Object Management:** Uses `Destroy(gameObject)` to remove the collectible after a successful interaction.
- **Modular Programming:** Separates collectible interactions from score management to organize gameplay logic.

This script demonstrates C# methods, conditional statements, Unity components, object references, and event-driven programming.

C# classes, variables, access modifiers, methods, conditional statements, comparison operators, Unity event methods, object references, and gameplay state management.

### Score Management and User Interface

The `ScoreManager.cs` script manages the player's chicken collection score and updates the on-screen display using Unity's TextMesh Pro system.

Key implementations include:

- **Score Initialization:** Initializes the player's score at zero.
- **Score Incrementing:** Uses the `AddChicken()` method to increase the score when a chicken is collected.
- **Dynamic UI Updates:** Updates the TextMesh Pro score display after each successful collection.
- **Script Communication:** Works with `ChickenCollect.cs` to separate collection detection from score tracking.
- **Code Reusability:** Uses a dedicated `UpdateScore()` method to manage changes to the displayed score.

**Programming concepts demonstrated:** C# methods, integer variables, access modifiers, method calls, object references, string concatenation, Unity lifecycle methods, and UI programming.
## How to Open the Project

1. Download or clone this repository.
2. Open Unity Hub.
3. Select **Add project from disk**.
4. Choose the downloaded project folder.
5. Open the project using a compatible Unity Editor version.
6. Locate the main gameplay scene in the Assets folder and open it.
7. Press **Play** to test the game.

## Future Improvements

- Refine gameplay mechanics
- Improve the user interface
- Add additional levels and challenges
- Enhance animations and sound effects
- Explore WebGL deployment for browser-based gameplay

## Developer

**London Medley**

B.S. Web and Digital Design Student

**Areas of Interest:** Game Development | C# Programming | Web Development | Digital Design

---

*Created as part of my game development learning journey.*
