# Chicken Chase — Unity Game Development Project

A Unity game development project created using C# as part of undergraduate coursework in Web and Digital Design.

This project explores interactive gameplay mechanics, player controls, object collection, collision detection, scoring, camera tracking, and game-state management.

## Technologies Used

- Unity Game Engine
- C#
- Unity Input System
- Unity Physics and Rigidbody
- TextMesh Pro
- Unity Audio and Particle Systems
- Git and GitHub

## Gameplay Systems

The project contains C# implementations for:

- **Player Movement:** Keyboard-controlled movement using Unity's Input System and alternative Rigidbody-based controls.
- **Collectible Objects:** Trigger-based collection mechanics for chickens and eggs.
- **Score Tracking:** Updating the player's collection count through C# methods and UI text.
- **Player Lives:** A three-life system that triggers a Game Over state when lives reach zero.
- **Obstacle Interactions:** Collision-based life reduction with audio and particle effects.
- **Countdown Timer:** A configurable timer that updates the display and handles time expiration.
- **Camera Tracking:** Camera-follow behavior using Vector3 offsets and Unity Transform methods.
- **Movement Boundaries:** Player-position restrictions implemented using `Mathf.Clamp()`.
- **Win Conditions:** Egg-collection logic that displays a victory message when the required number is reached.

*These features are documented from the project's C# scripts. Some implementations may belong to different scenes or development stages.*

## Technical Implementation

### Player Controls

Implemented multiple movement approaches using Unity's Input System, keyboard input, Transform manipulation, and Rigidbody movement.

Used `Vector2` and `Vector3` to calculate movement directions, `Time.deltaTime` for frame-rate-independent Transform movement, and vector normalization to maintain consistent movement speed.

### Object Collection and Scoring

Created collectible-object scripts using trigger detection and Unity tags.

Connected `ChickenCollect.cs` with `ScoreManager.cs` to update the collection count and display the results using TextMesh Pro.

Implemented separate egg-collection and win-condition logic through `ChickenGameManager.cs`.

### Lives and Obstacle Management

Connected `FoodObstacle.cs` with `LifeManager.cs` to reduce the player's remaining lives when an obstacle is encountered.

Integrated audio playback and optional particle effects to provide feedback during collisions.

Implemented Game Over behavior that displays a message and pauses scaled gameplay when all lives are lost.

### Timer and UI Management

Created a configurable countdown timer using C# variables, conditional statements, and Unity's frame-update methods.

Used TextMesh Pro and GameObject visibility controls to update and manage gameplay interface elements.

### Camera and Environment Controls

Implemented camera-follow behavior using Transform positions, Vector3 offsets, `Update()`, and `LateUpdate()`.

Used `Mathf.Clamp()` to restrict player movement within designated gameplay boundaries.

## C# Programming Skills Demonstrated

- Classes and inheritance
- Variables and data types
- Public and private access modifiers
- Methods and method calls
- Conditional statements
- Comparison and arithmetic operators
- Vector mathematics
- Event-driven programming
- Unity lifecycle methods
- Component references and script communication
- Collision and trigger detection
- GameObject management
- User interface programming

## Project Structure

```text
ChickenChase-Unity-Game/
├── Assets/
│   └── Scripts/
│       ├── CameraFollow.cs
│       ├── ChickenCollect.cs
│       ├── ChickenGameManager.cs
│       ├── FollowPlayer.cs
│       ├── FoodObstacle.cs
│       ├── GameTimer.cs
│       ├── GreyboxPlayerController.cs
│       ├── LifeManager.cs
│       ├── PlayerController.cs
│       ├── PlayerMovement.cs
│       └── ScoreManager.cs
├── Packages/
├── ProjectSettings/
└── README.md
```

## How to Open the Project

1. Clone or download this repository.
2. Open Unity Hub.
3. Select **Add project from disk**.
4. Choose the downloaded project folder.
5. Open the project using a compatible Unity Editor version.
6. Open an available scene and run it in the Unity Editor.

## Future Improvements

- Consolidate movement scripts where appropriate.
- Improve Rigidbody movement using `FixedUpdate()`.
- Add restart and replay functionality.
- Coordinate timer expiration with game-over behavior.
- Refine camera tracking and collision feedback.
- Create a playable build for portfolio demonstrations.

## Developer

**London Medley**

Web and Digital Design undergraduate developing skills in frontend web development, C# programming, Unity game development, and interactive digital experiences.

GitHub: [LondonM2](https://github.com/LondonM2)
