# Rendu TD6
  
  * Auteur : Eliel WOTOBE
  * Contenu : 
     C'est un rendu tr�s minimal qui permet d'ex�cuter trois projets : ClientSOAP, ServeurSOAP, ServeurREST.

     Le ClientSOAP permet de tester le Serveur SOAP et fait afficher trois valeurs :
       * 1 + 2
       * 4 - 2 
       * 3 * 3
     Le ServeurREST permet d'utiliser les op�rations d'addition, soustraction et de multiplication � partir du navigateur.
     Pour ex�cuter les op�rations sur ce serveur il faut lancer les lien suivants: 
      * addition : http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/add?x= {int}&y={int}
      * soustraction : http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/substract?x= {int}&y={int}
      * multiplication : http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/multiply?x= {int}&y={int}

   