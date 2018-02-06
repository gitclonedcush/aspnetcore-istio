# aspnetcore-istio

## Setup
* Install Istio: https://istio.io/docs/setup/kubernetes/quick-start.html
  * Don't need to install automatic sidecar injection for this tutorial

## Running on Kubernetes
* Build docker image ```docker build -t grade-service:v1 .```
* Run ```bash ./up.sh```
  * This will create a grade service deployment, service, and ingress
* Get the ingress/gateway ip using ```export GATEWAY_URL=$(kubectl get po -l istio=ingress -n istio-system -o 'jsonpath={.items[0].status.hostIP}'):$(kubectl get svc istio-ingress -n istio-system -o 'jsonpath={.spec.ports[0].nodePort}')```
* Request grades at ```$GATEWAY_URL/api/grades```
* Cleanup with ```bash ./cleanup.sh```