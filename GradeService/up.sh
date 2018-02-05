DIR=$(dirname $0)

kubectl apply -f ${DIR}/deployment.yaml -n envoy
kubectl apply -f ${DIR}/service.yaml -n envoy