This project follows the Unity course: https://learn.unity.com/pathway/junior-programmer/unit/player-control?version=6.0

Return later and complete the bonus challenges: https://learn.unity.com/tutorial/bonus-features-1-share-your-work

Unit Guide:

### Unity Junior Programmer – Unit 1  
#### Concepts & Controls Guide (Player Control)

### Unit Focus

Unit 1 introduces the foundational programming and gameplay systems needed to control a player object in Unity. The primary goal is to move and rotate a vehicle using player input while learning core scripting concepts.

### Core Programming Concepts Learned

#### 1. MonoBehaviour

All gameplay scripts inherit from:

`public class PlayerController : MonoBehaviour`

- Allows the script to attach to GameObjects
- Gives access to Unity lifecycle methods like `Start()` and `Update()`

---

#### 2. Unity Lifecycle Methods

#### `Start()`
- Runs once when the object is initialized
- Used for setup

#### `Update()`
- Runs every frame
- Used for player input and movement

### 3. Variables

#### Public Variables
`public float speed = 10f;`

- Visible in the Inspector
- Adjustable without changing code
- Used for tuning gameplay

#### Private Variables
`private float turnInput;`

- Only accessible within the script
- Used for internal calculations

### 4. Data Types

| Type | Purpose |
|------|----------|
| `float` | Decimal numbers (movement speed) |
| `int` | Whole numbers |
| `bool` | True/False values |
| `Vector3` | 3D direction or position |

### 5. The Transform Component

Every GameObject has a Transform that controls:

- Position
- Rotation
- Scale

Accessed with:
`transform`

### 6. Movement with Translate

```transform.Translate(Vector3.forward * speed * Time.deltaTime);```

#### Key Concepts:
- `Vector3.forward` → Moves along Z-axis
- `speed` → Movement multiplier
- `Time.deltaTime` → Makes movement frame-rate independent

### 7. Rotation with Rotate

```transform.Rotate(Vector3.up * turnSpeed * turnInput * Time.deltaTime);```

- `Vector3.up` → Rotates around Y-axis
- Multiplied by input value
- Frame-rate independent

---

### 8. Player Input System (Old Input Manager)

#### GetAxis()

```Input.GetAxis("Horizontal");```
```Input.GetAxis("Vertical");```

- Returns value between -1 and 1
- Smooth input
- Controlled in Project Settings → Input Manager

### 9. Frame-Rate Independence

Using:

`Time.deltaTime`

Ensures:
- Movement speed remains consistent
- Gameplay works the same on fast and slow machines

Without it:
- Faster PCs = faster movement
- Slower PCs = slower movement

### 10. Debugging

#### Console Output

```Debug.Log("Message");```

Used to:
- Check variable values
- Confirm code execution
- Diagnose issues

---

### Controls Learned in Unit 1

#### Horizontal Movement (Turning)

| Input | Key |
|--------|------|
| Turn Left | A or Left Arrow |
| Turn Right | D or Right Arrow |

Code:
```Input.GetAxis("Horizontal");```

#### Vertical Movement (Forward/Backward if implemented)

| Input | Key |
|--------|------|
| Move Forward | W or Up Arrow |
| Move Backward | S or Down Arrow |

Code:
```Input.GetAxis("Vertical");```

## Game Design Concepts Introduced

### 1. Player Control System
- Player input drives movement
- Movement affects transform

### 2. Inspector Tuning
- Adjusting speed values without code changes
- Rapid iteration workflow

### 3. Component-Based Architecture
GameObjects are made of components:
- Transform
- Mesh Renderer
- Colliders
- Scripts

---

## Example Final Script Structure

```
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f;

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * turnInput * Time.deltaTime);
    }
}
```

### Skills Gained After Unit 1

- Create and attach C# scripts
- Use Unity lifecycle methods
- Read player input
- Move and rotate objects
- Understand frame-rate independence
- Tune gameplay using Inspector
- Debug simple issues

### Summary

Unit 1 builds the foundation for all future gameplay programming:

- Input → Processing → Movement
- Variables control behavior
- `Update()` drives gameplay
- `Time.deltaTime` ensures consistency

Mastering these concepts prepares you for physics, collisions, spawning systems, and more advanced mechanics in later units.
