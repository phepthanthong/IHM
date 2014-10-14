==================================
PUF-HCM				 
Nom et Prénom: MAI Trung Hieu
Classe: LINF13
==================================

					Rapport du projet C# - Sudoku
						~~~~~~~~~~
	I.Objectif
		Une interface permettant de charger un problème de Sudoku à partir d'un fichier.
	II. Réalisation
		
     * Class Case
		- Cette classe est dérivée de TextBox et se comporte 3 attributs: 2 nombres entiers i et j afin de postionner la case dans la fenêtre Sudoku, un attribut jeu de type Sudoku
		- Le constructeur de Case recoit en paramètre ces 3 attributs.
		- Les propriétes utilisées
			+ Anchor: permettre la redimension de la case avec son parent		
			+ MaxLength: limiter le nombre de caractères entrée dans une case
			+ TextAlign: afficher le caractère au milieu de la case
 
     * Class principale Sudoku
		- Son attibut est "grille", un tableau 9*9 de type Case
		- Son constructeur doit instancier cet attribut afin d'afficher sur le formulaire 81 Cases de type TextBox
		- On ajoute dans le constructeur un panelDessin pour dessiner les lignes délimitant les cases 3*3

		@ Interface
			- Interface contient une barre de menu avec 2 buttons principaux: Jeu et Aide (Déjà expliqué dans le sujet); 
				quelques buttons de la page d'accueil (Play,Instruction,Page d'Accueil).
			- Au démarrage du programmme, une page d'accueil sera affichée avec un titre, 2 buttons Play et Instruction, et le nom de l'auteur.
			- Lorsque l'utilisateur appuie sur Instruction, un manuel d'utilisateur apparait indiquant comment jouer le jeu.
			- Lorsque l'utilisateur appuie sur Play, une grille de 81 cases apparaissent sur l'écran.
			- Au-dessous de la fenêtre, un button Page d'Accueil permet le retour à la page d'accueil.
			- On ne peut pas dessiner les lignes délimitant les cases 3*3 par l'événment Paint comme d'habitude.
				Ici, on utilise un panel de dessin qui pourrait modifier son location sur la fenêtre.

		@ Regles
			- On définit ici les fonctions permettant la vérification du règle du jeu Sudoku
			- Une fonction estGagnant() vérifie si l'utilisateur est terminé en gagant le jeu.
			- La fonction VerifierRegle est booléenne en raison de sa réutilisation fréquente dans le code

		@ Evenements
			- Dans ce champ, on gère 2 événements importants du programme: TextChanged et KeyPress
			- TextChanged permet d'identifier un changement dans une case, cherche cette case grâce à la propriété Focused, et vérifie la validité de la valeur entrée
			- KeyPress permet la saisie d'un chiffre, pas d'une lettre

		@ Aides
			- Comme indiqué dans le sujet, le programme dispose de 2 aides fondamentales: les valeurs possibles d'une case et les cases possibles d'une valeur
			- Pour la première, on utilise l'événement DoubleClick:
				+ On va prendre une chaine de numero (de 1 à 9) et va tester chaque valeur dans la case sélectionnée
            			+ On affecte chaque valeur dans cette case et vérifie la validité de celle-ci.
            			+ On fait attention à l'événement TextChanged puisque, à chaque fois qu'on affecte une valeur, le programme appelle cet événement
				+ Enfin, on affiche sur l'écran un message contenant les valeurs possibles dans la case
			- La deuxième aide se trouve sur la barre de menu "Aide" qui contient 9 valeurs 
				+ Chaque valeur de 1 à 9 va appeler une même fonction
				+ Même principe qu'au-dessus, on prend en compte l'événement TextChanged, vérifie la valeur entrée et indique dans quelle case pourrait insérer cette valeur.
	
	III. Limites et Améliorations
		- L'ajout des nouvelles fonctionnalités est bienvenue (compter la durée, créer aléatoirement une grille, autres types de suggestion, créer différents niveaux de difficulté,...) 