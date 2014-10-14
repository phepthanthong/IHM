==================================
PUF-HCM				 
Nom et Pr�nom: MAI Trung Hieu
Classe: LINF13
==================================

					Rapport du projet C# - Sudoku
						~~~~~~~~~~
	I.Objectif
		Une interface permettant de charger un probl�me de Sudoku � partir d'un fichier.
	II. R�alisation
		
     * Class Case
		- Cette classe est d�riv�e de TextBox et se comporte 3 attributs: 2 nombres entiers i et j afin de postionner la case dans la fen�tre Sudoku, un attribut jeu de type Sudoku
		- Le constructeur de Case recoit en param�tre ces 3 attributs.
		- Les propri�tes utilis�es
			+ Anchor: permettre la redimension de la case avec son parent		
			+ MaxLength: limiter le nombre de caract�res entr�e dans une case
			+ TextAlign: afficher le caract�re au milieu de la case
 
     * Class principale Sudoku
		- Son attibut est "grille", un tableau 9*9 de type Case
		- Son constructeur doit instancier cet attribut afin d'afficher sur le formulaire 81 Cases de type TextBox
		- On ajoute dans le constructeur un panelDessin pour dessiner les lignes d�limitant les cases 3*3

		@ Interface
			- Interface contient une barre de menu avec 2 buttons principaux: Jeu et Aide (D�j� expliqu� dans le sujet); 
				quelques buttons de la page d'accueil (Play,Instruction,Page d'Accueil).
			- Au d�marrage du programmme, une page d'accueil sera affich�e avec un titre, 2 buttons Play et Instruction, et le nom de l'auteur.
			- Lorsque l'utilisateur appuie sur Instruction, un manuel d'utilisateur apparait indiquant comment jouer le jeu.
			- Lorsque l'utilisateur appuie sur Play, une grille de 81 cases apparaissent sur l'�cran.
			- Au-dessous de la fen�tre, un button Page d'Accueil permet le retour � la page d'accueil.
			- On ne peut pas dessiner les lignes d�limitant les cases 3*3 par l'�v�nment Paint comme d'habitude.
				Ici, on utilise un panel de dessin qui pourrait modifier son location sur la fen�tre.

		@ Regles
			- On d�finit ici les fonctions permettant la v�rification du r�gle du jeu Sudoku
			- Une fonction estGagnant() v�rifie si l'utilisateur est termin� en gagant le jeu.
			- La fonction VerifierRegle est bool�enne en raison de sa r�utilisation fr�quente dans le code

		@ Evenements
			- Dans ce champ, on g�re 2 �v�nements importants du programme: TextChanged et KeyPress
			- TextChanged permet d'identifier un changement dans une case, cherche cette case gr�ce � la propri�t� Focused, et v�rifie la validit� de la valeur entr�e
			- KeyPress permet la saisie d'un chiffre, pas d'une lettre

		@ Aides
			- Comme indiqu� dans le sujet, le programme dispose de 2 aides fondamentales: les valeurs possibles d'une case et les cases possibles d'une valeur
			- Pour la premi�re, on utilise l'�v�nement DoubleClick:
				+ On va prendre une chaine de numero (de 1 � 9) et va tester chaque valeur dans la case s�lectionn�e
            			+ On affecte chaque valeur dans cette case et v�rifie la validit� de celle-ci.
            			+ On fait attention � l'�v�nement TextChanged puisque, � chaque fois qu'on affecte une valeur, le programme appelle cet �v�nement
				+ Enfin, on affiche sur l'�cran un message contenant les valeurs possibles dans la case
			- La deuxi�me aide se trouve sur la barre de menu "Aide" qui contient 9 valeurs 
				+ Chaque valeur de 1 � 9 va appeler une m�me fonction
				+ M�me principe qu'au-dessus, on prend en compte l'�v�nement TextChanged, v�rifie la valeur entr�e et indique dans quelle case pourrait ins�rer cette valeur.
	
	III. Limites et Am�liorations
		- L'ajout des nouvelles fonctionnalit�s est bienvenue (compter la dur�e, cr�er al�atoirement une grille, autres types de suggestion, cr�er diff�rents niveaux de difficult�,...) 