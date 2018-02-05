DIR=$(dirname $0)

kubectl apply -f <(istioctl kube-inject -f grade-service.yaml)