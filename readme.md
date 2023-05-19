# 부산대학교 대학원 연구실 인턴쉽(공학연구실습I)

2023년 1학기 공학연구실습I 대학원 연구실 인턴쉽입니다.

## List
1. [신약 후보 물질 발굴을 위한 인공지능 시스템 개발 실습(3.13. ~ 4.14.)](https://github.com/jagaldol/lab-internship/tree/main/Machine%20Learning%20and%20Bioinformatics%20Lab)
2. [Deep Learning & Computer Vision 기초 이해 및 Google Colab 실습(4.17. ~ 5.19.)](https://github.com/jagaldol/lab-internship/tree/main/Visual%20Intelligence%20and%20Perception%20Lab)
3. [Unity를 활용한 VR 콘텐츠 제작 실습 및 연구 주제 탐구(5.22. ~ 6.23.)](https://github.com/jagaldol/lab-internship/tree/main/eXtended%20Reality%20and%20HCI%20lab)

> Please check each directory's README!

## Summarized Key Contents
### DeepBind를 사용한 신약 후보 물질 발굴(1그룹)

> "Predicting the sequence specificities of DNA-and RNA-binding proteins by deep learning." Nature biotechnology(2015)

![fig1](./Machine%20Learning%20and%20Bioinformatics%20Lab/assets/deepbind_Fig1.webp)

1. High-throughput experiments(고효율 실험) - 데이터 수집 및 가공 단계  
    기존 고전적인 방법(SELEX, RBPs 등)을 한 cycle만 수행하여 데이터 셋 확보  
2. Massively parallel deep learning - 딥러닝 학습 단계  
3. Community needs - 모델을 바탕으로 분석 수행 단계

실험을 통해 얻은 신약후보물질(Aptamer) 데이터를 딥러닝하여 새로운 신약후보물질을 찾아낸다.

### 모델 구조
> 수식 표현: $f(s) = net_W(pool(rect_b(conv_M(s))))$

![fig2](./Machine%20Learning%20and%20Bioinformatics%20Lab/assets/deepbind_Fig2.webp)

## DeepLearning with Colab(2그룹)

colab 노트북 환경에서의 딥러닝 신경망 기법 학습 및 실습

- 학습 딥러닝 기법  
    1. Introduction to AI and Deep Learning and Perceptron
    2. MNIST Classifier with Multi Layer Perceptron
    3. MNIST Classifier with Convolutional Neural Network
    4. Simple Chatbot with Recurrent Neural Network
    5. Introduce of Generative Models

## 3그룹 실습 완료 후 추가 예정