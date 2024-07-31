# AutoRigFinder

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction
**AutoRigFinder** is a Unity script designed to automatically locate and assign common rig elements (such as head, hands, and feet) in a character's skeleton. This tool can be useful in speeding up the rigging process, particularly in projects involving animated characters.

## Features
- Automatically finds and assigns references for:
  - Head
  - Left Hand
  - Right Hand
  - Left Foot
  - Right Foot
- Integrates seamlessly into the Unity Editor with a custom inspector button to trigger the auto-find function.

## Installation
To add the `AutoRigFinder` script to your Unity project:

1. **Download the script:**
   - You can copy the code from the script file directly, or download it from the repository if it's hosted online.

2. **Add to your project:**
   - Place the `AutoRigFinder.cs` script in your Unity project's `Assets/Scripts/` directory.

3. **Assign the script to a GameObject:**
   - Attach the `AutoRigFinder` script to a GameObject in your scene that has an `Animator` component.

## Usage
### Using AutoRigFinder in the Unity Editor
1. **Attach the script:**
   - Attach the `AutoRigFinder` script to a GameObject that has an `Animator` component.

2. **Open the Custom Inspector:**
   - Select the GameObject in the Unity Editor to view the script's custom inspector.

3. **Click "Auto Find":**
   - In the inspector, click the "Auto Find" button to automatically locate and assign the head, hands, and feet from the character's animator.

### Script Details
Here is a brief overview of how the script works:
- The `AutoFind` method looks for the `Animator` component on the GameObject and assigns the respective bone transforms to the `head`, `leftHand`, `rightHand`, `leftFoot`, and `rightFoot` variables.
- If no `Animator` component is found, a warning is logged in the console.

## Contributing
If you would like to contribute to the development of this script, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bugfix (`git checkout -b feature-name`).
3. Make your changes and commit them (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Open a pull request to merge your changes.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact
If you have any questions or feedback, feel free to reach out:

- GitHub: [BananaofGOD](https://github.com/BananaofGOD)
- Email: official@wonderwordsgames.com
