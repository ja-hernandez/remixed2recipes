\connect recipedb
CREATE USER recipeadmin;
GRANT ALL PRIVILEGES ON DATABASE recipedb to recipeadmin;

CREATE TABLE recipe
(
 id serial PRIMARY KEY,
 recipe_name VARCHAR (100) NOT NULL,
 instructions_id INT

);

ALTER TABLE "recipe" OWNER TO recipeadmin;
Insert into recipe(recipe_name) values('Tasty Pie 1');
Insert into recipe(recipe_name) values('Tasty Pie 2');
Insert into recipe(recipe_name) values('Tasty Pie 3');
Insert into recipe(recipe_name) values('Tasty Pie 4');
