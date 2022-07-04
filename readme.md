Cours de design pattern
=======================

## Notation : 
- A rendre
  - Projet applis console avec les design patterns appris
  - QCM

Slide avec résumé a la fin

## Définition :
- Ce sont des schémas d'objets qui permettent de trouver une solution à un problème courrant
- Il srépondent a un problème de conception POO
- Ils résultent de méthodes de bonne pratiques en POO

## Les Patterns :

Il existe 23 patterns

### Abstract factory

<img src="images/abstract_factory.png" alt="Abstract factory" width="400"/>

Au lieu de créer une classe mère __``Catalogue``__ surchargée de fonctions
A chaque fois qu'une nouvelle famille de vehicule est prise en compte

On utilise le design pattern __``Abstract Factory``__ 
Le but du pattern est de résoudre tous les problèmes liés a la création de classes et au fait de surcharger la classe parente

Création d'une fabrique de vehicule en créant une interface qui contient les signatures des fonctions

Signature d'une fonction ~= prototype en c++

Description de __``Scooter``__ :
- Un ``Scooter`` peut être un electrique ou essence
- Un ``ScooterElectricite`` est créé par la ``FabriqueVehiculeElectricite``
- Un ``ScooterEssence`` est créé par la ``FabriqueVehiculeEssence``

Une interface n'est qu'un comportement
Une classe abstraite avec des methodes sans implémnetations.
Le catalogue peut créer des vehicules peu importe son type


Diagramme + générique :
<img src="images/abstract_factory_2.png" alt="Abstract factory" width="400"/>

### Quelques rappels :
Une classe abstraite n'est pas isntanciable
Les attributs peuvent être :
- public (accessible de partout)
- private (accessible uniquement dans la classe)
- protected (accessible dans la classe et dans les classes filles)

```c#
public interface FabriqueVehicule{
   Automobile creerAutomobile(string modele, string couleur, int puissance, double espace);
}

public class FabriqueAutomobileELectrique : FabriqueVehicule{
   public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
   {
      return new AutomobileElectrique(modele, couleur, puissance, espace);
   }
}
```
Voir exemple complet ici dans ``project_example/design_pattern_1/``