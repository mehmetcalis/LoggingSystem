# Logging System

## Overview

This project implements a versatile logging system in C# that allows logging messages to various outputs, such as the console, a file, and an in-memory store. The design follows SOLID principles, design patterns, Dependency Injection, and coding best practices.

## Project Structure

The project is organized into several classes, each serving a specific purpose:

- `ILogger`: Interface defining the logging contract.
- `ConsoleLogger`: Logs messages to the console.
- `FileLogger`: Logs messages to a file.
- `InMemoryLogger`: Logs messages to an in-memory store.
- `LoggerFactory`: Factory class for creating different logger instances.
- `LoggerType`: Enum defining the types of loggers.

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/LoggingSystem.git
