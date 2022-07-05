# ruan.aplication.csharp

Para iniciar o container MySQL execute o comando abaixo:
```bash
sudo docker-compose up --detach
```

Para importar as alterações no esquema do banco de dados:

```bash
sudo docker exec -i mysql_test sh -c 'exec mysql -u root -p "$MYSQL_ROOT_PASSWORD"' < ./ruan.database.sql
```

Para acessar o banco de dados use o comando abaixo:

```bash
docker exec -it mysql_test bin/bash
```
