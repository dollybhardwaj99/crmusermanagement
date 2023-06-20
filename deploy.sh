aws eks --region ap-south-1 update-kubeconfig --name SMR-API
# kubectl delete service   name: insurance-smr-lb
# kubectl apply -f service.yaml 
kubectl delete deployment insurance-api-demo
kubectl apply -f deployment.yaml 