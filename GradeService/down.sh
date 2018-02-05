DIR=$(dirname $0)

kubectl delete -f ${DIR}/deployment.yaml -n envoy
kubectl delete -f ${DIR}/service.yaml -n envoy