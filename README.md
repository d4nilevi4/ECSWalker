# 🧠 Unity ECS Project (Entitas-Based)

## 📦 Overview

This project is a Unity game structured around the **Entitas** Entity Component System (ECS) architecture.

The project contains:

- ?

> ⚠️ This repository does **not** include several third-party assets from the Unity Asset Store due to licensing restrictions. These assets must be downloaded manually.

---

## 🛠 Technologies Used

- **Unity** (version 6000.0.32f1)
- **Entitas** ECS Framework ([link](https://github.com/sschmid/Entitas))
- **UniTask** for async programming ([link](https://github.com/Cysharp/UniTask))
- **Zenject** DI Framework ([link](https://github.com/modesttree/Zenject))

---

## 🔌 Excluded Assets (not in repo, listed in `.gitignore`)

The following assets are used in the project but are **excluded from the repository**. You need to import them manually into the Unity project for everything to compile and work properly.

#### 1. [A* Pathfinding Project Pro](https://assetstore.unity.com/packages/tools/behavior-ai/a-pathfinding-project-pro-87744)

---

## 🧩 Folder Structure (Short Summary)

Assets/\
├── _Project/\
│   └── Code/ # The entire project code\
│   └── Scenes/ # All used scenes in project\
├── Entitas/ # EntitasECS code\
├── Packages/ # Packeges installed via NuGet for Unity\
├── Setting/ # Project settings, includes Render Pipeline setting and  Input settings
---