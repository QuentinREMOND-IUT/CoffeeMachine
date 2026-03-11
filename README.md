# ☕ Coffee Machine - Projet BUT Informatique

Ce projet a été réalisé dans le cadre d'une évaluation de **Développement Objet** en première année de **BUT Informatique** (TP4). L'objectif est de simuler le fonctionnement interne d'une machine à café programmable en C#.

---

## 🎯 Objectifs du Projet
Le but de cet exercice était de mettre en pratique les concepts fondamentaux de la Programmation Orientée Objet (POO) :
* **Encapsulation** : Utilisation de champs privés et de propriétés (`get`/`set`).
* **Gestion d'état** : Suivi des stocks (eau, café, sucre) et de la caisse.
* **Logique métier** : Vérification des ressources avant distribution.
* **Propriétés calculées** : Calcul dynamique du prix d'une boisson.

---

## 🏗️ Structure du Code

Le projet est divisé en trois composants principaux :

### 1. La classe `CoffeeMachine`
C'est le cœur du système. Elle gère :
* Le nom et le code d'identification de la machine.
* Le stock de consommables.
* La méthode `GiveCoffee` qui vérifie si les ressources sont suffisantes avant de créer une distribution.
* Le rechargement des ingrédients via les méthodes `Reload`.

### 2. La classe `Distribution`
Elle représente l'objet "Boisson" généré. Son coût est calculé automatiquement selon la formule suivante :
$$Coût = (0.70 \times café) + (0.01 \times eau) + (0.10 \times sucre)$$

### 3. La classe `Program`
Le point d'entrée qui contient les scénarios de test :
* Initialisation de la machine ("K-fé IUT").
* Remplissage des réservoirs.
* Simulations de commandes (cafés courts, longs, sucrés).
* Test des limites de stocks avec une boucle de distribution.

---

## 🛠️ Fonctionnalités clés

| Action | Description |
| :--- | :--- |
| **Distribution** | Gère le type de café (Court/Long) et la dose de sucre. |
| **Gestion Stocks** | Décrémente l'eau, le café et le sucre à chaque commande réussie. |
| **Caisse** | Accumule l'argent des ventes. La méthode `TakeMoney()` permet de vider la caisse. |
| **Sécurité** | Retourne `null` si une ressource vient à manquer, empêchant une distribution incomplète. |

---

## 🚀 Installation et Test

1. Clonez le dépôt ou copiez les fichiers `.cs`.
2. Ouvrez le projet dans **Visual Studio** ou **VS Code**.
3. Compilez et lancez le projet :
   ```bash
   dotnet run
