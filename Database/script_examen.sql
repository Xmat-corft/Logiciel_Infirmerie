-- Connexion avec l'utilisateur 'candidat' (comme demandé dans le sujet)
CREATE DATABASE examen;
USE examen;

CREATE TABLE eleves (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50),
    prenom VARCHAR(50),
    classe VARCHAR(20),
    annee_scolaire INT
);
