#INSTALL AWS CLI

sudo pip install setuptools
sudo pip install wheel
sudo pip install awscli --upgrade

 

#INSTALL KUBECTL

#curl -o kubectl https://amazon-eks.s3-us-west-2.amazonaws.com/1.11.5/2018-12-06/bin/linux/amd64/kubectl
curl -o kubectl https://s3.us-west-2.amazonaws.com/amazon-eks/1.23.7/2022-06-29/bin/linux/amd64/kubectl

chmod +x ./kubectl

sudo mv ./kubectl /usr/local/bin/kubectl

 

 

#INSTALL AUTHENTICATOR

curl -o aws-iam-authenticator https://amazon-eks.s3-us-west-2.amazonaws.com/1.11.5/2018-12-06/bin/linux/amd64/aws-iam-authenticator

chmod +x ./aws-iam-authenticator

sudo mv ./aws-iam-authenticator /usr/local/bin/aws-iam-authenticator

#DEPLOY UPDATE
aws eks --region ap-south-1 update-kubeconfig --name PSFLEADMANAGEMENT-DEV-Cluster
kubectl config view
kubectl get all
kubectl delete deployment server-demo
kubectl apply -f deployment/deployment.yaml
