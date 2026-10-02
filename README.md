# Проект: API сервиса задач

## Описание
API-приложение на .NET 6 в Docker-контейнере.
Эндпоинты:
- GET /health — проверка работоспособности
- GET /tasks — список задач

## Сборка
docker build -t my-api .

## Запуск
docker run -d -p 8080:8080 --name my-api-container my-api

## Проверка
curl http://localhost:8080/tasks
curl http://localhost:8080/health

## Команды
- docker ps — список контейнеров
- docker logs my-api-container — логи
