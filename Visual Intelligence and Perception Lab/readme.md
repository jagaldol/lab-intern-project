# 시각 지능 및 인지 연구실

Deep Learning & Computer Vision 기초 이해 및 Google Colab 실습

* 지도교수: 박진선 교수님
* Duration: 2023. 4.17 ~ 2023. 5.19.

## Installation
> using python 3.11.2

### set python virtual environment
* Linux  
    ```sh
    $ cd "Visual Intelligence and Perception Lab"
    $ activate_venv.sh
    (.venv) $
    ```
* Windows  
    ```cmd
    > cd "Visual Intelligence and Perception Lab"
    > activate_venv.bat
    (.venv) >
    ```

### install packages
```shell
(venv) $ pip install -r requirements.txt
```

## Contents
<!-- 1. Multi Layer Perceptron
2. Convolutional Neural Network
3. TensorFlow vs PyTorch
4. Recurrent Neural Network
5. DeepBind

## DeepBind를 사용한 신약 후보 물질 발굴
> "Predicting the sequence specificities of DNA-and RNA-binding proteins by deep learning." Nature biotechnology(2015)

![fig1](./assets/deepbind_Fig1.webp)

1. High-throughput experiments(고효율 실험) - 데이터 수집 및 가공 단계  
    기존 고전적인 방법(SELEX, RBPs 등)을 한 cycle만 수행하여 데이터 셋 확보  
2. Massively parallel deep learning - 딥러닝 학습 단계  
3. Community needs - 모델을 바탕으로 분석 수행 단계

실험을 통해 얻은 신약후보물질(Aptamer) 데이터를 딥러닝하여 새로운 신약후보물질을 찾아낸다.

### 모델 구조
> 수식 표현: $f(s) = net_W(pool(rect_b(conv_M(s))))$

![fig2](./assets/deepbind_Fig2.webp)

1. Convolve
2. RELU 함수
3. POOLING
4. FULLY Connectied(DENSE)

> **CNN을 사용하는 이유?**  
> RNN의 경우 전체 타임스탬프 순서가 중요하다.  
> 여기서는 지엽적인 정보, Aptamer 내부의 motif,를 찾아야해서 CNN이 더 효율적이다. -->