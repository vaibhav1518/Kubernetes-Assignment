
# Kubernetes Deployment for ASP.NET Core Web API

This project contains a simple ASP.NET Core Web API deployed in a Kubernetes cluster using Minikube.

## Prerequisites

- Minikube installed.
- kubectl installed.

## Instructions

1. **Start Minikube**:
   
   Open a terminal and start Minikube:
   ```bash
   minikube start
   ```

2. **Apply Kubernetes deployment and service configuration**:
   
   Deploy your application to the Kubernetes cluster using the following command:
   ```bash
   kubectl apply -f deployment.yml
   ```

3. **Start Minikube tunnel**:
   
   Create a tunnel to access the service externally:
   ```bash
   minikube tunnel
   ```

4. **Check services and get external IP**:
   
   List services to find the external IP of the application:
   ```bash
   kubectl get services
   ```

5. **Access the application**:
   
   Use the external IP and exposed port to access your application in a browser:
   ```
   http://<external-ip>:8082/kube
   ```
