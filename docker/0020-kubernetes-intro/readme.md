# Kubernetes Introduction

## Prerequisites

1. Install [*Azure CLI*](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest)
2. Install [*Docker Desktop*](https://docs.docker.com/docker-for-windows/install/) or [*Docker CE*](https://docs.docker.com/install/linux/docker-ce/debian/)
3. Install [*kubectl*](https://kubernetes.io/docs/tasks/tools/install-kubectl/)

## Create Kubernetes in Azure

**Note:** These steps have to be performed by your teacher in an Azure subscription that has benefits or an assigned credit card for covering the costs.

1. Create *Kubernetes Service* in Azure

2. Setup a *Service Principal* that can be used to access the K8S cluster:

```bash
RG=HTL-Perg-K8S
K8S=htl-perg-k8s
NS=nvs-mc
SUBSCR=b33f0285-db27-4896-ac5c-df22004b0aba

az login
az account set --subscription $SUBSCR

# Get ID of K8S cluster
AKS_ID=$(az aks show --resource-group $RG --name $K8S --query id -o tsv)

# Create/get ID of group for students
APPDEV_ID=$(az ad group create --display-name "HTL Perg 2019/20 Students" --mail-nickname htlstudents1920 --query objectId -o tsv)
# APPDEV_ID=$(az ad group list --display-name "HTL Perg 2019/20 Students" | jq ".[0].objectId" -r)

AKSDEV_ID=$(az ad user create --display-name "AKS Dev" --user-principal-name "...@...onmicrosoft.com" --password "..." --query objectId -o tsv)
# AKSDEV_ID=$(az ad user list --display-name "AKS Dev" | jq ".[0].objectId" -r)
az ad group member add --group $APPDEV_ID --member-id $AKSDEV_ID

az role assignment create --assignee $APPDEV_ID --role "Azure Kubernetes Service Cluster User Role" --scope $AKS_ID
# az role assignment delete --assignee $APPDEV_ID --role "Azure Kubernetes Service Cluster User Role" --scope $AKS_ID


# APPDEV_ID=$(az ad group create --display-name "HTL Perg 2019/20 Students" --mail-nickname htlstudents1920 --query objectId -o tsv)
APPDEV_ID=$(az ad group list --display-name "HTL Perg 2019/20 Students" | jq ".[0].objectId" -r)
az role assignment create --assignee $APPDEV_ID --role "Azure Kubernetes Service Cluster User Role" --scope $AKS_ID
az role assignment delete --assignee $APPDEV_ID --role "Azure Kubernetes Service Cluster User Role" --scope $AKS_ID

az aks browse --resource-group $RG --name $K8S
```

## Sign-in to K8S

```bash
az login --username ...@...onmicrosoft.com --password ...

RG=HTL-Perg-K8S
K8S=htl-perg-k8s
az aks get-credentials --resource-group $RG --name $K8S --overwrite-existing

kubectl get all
```

## Execute Exercises

* See [Kubernetes Workshop Slides](https://github.com/rstropek/DockerVS2015Intro/blob/master/slides/Kubernetes-Workshop.pptx)
* [*HTTP application routing* sample](https://docs.microsoft.com/en-us/azure/aks/http-application-routing)
