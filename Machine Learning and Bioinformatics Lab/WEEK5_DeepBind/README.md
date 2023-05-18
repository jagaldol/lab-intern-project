# DeepBind

2015년, Nature biotechnology에 나온 논문

## Aptamer
DNA/RNA로 이루어진 뉴클레오타이드 서열

표적물질(target protein)에 잘 달라붙는 물질(Aptamer)을 찾아야한다.

## SELEX(Systematic Evoluiton of Ligands by EXponentail enrichment)
기존 압타머 후보 서열 발굴 실험(딥러닝 x)

selex를 통해 타겟 단백질이랑 아타머들을 생성, 가상으로 융합 후 잘 안 붙는거 버리고 융합 잘되는거만 살려서 이것들을 다시 oversampling 후 다른 타겟 단백질 생성해서 실험해보는것


## RBPs(RNA Binding Proteins)
ACTGGTG -> GGT가 수용체에 잘 붙네? -> MOTIF라고 명명

    Motif는 뉴클레오타이드, 아미노산 서열 패턴을 의미


> 기존 방법들은 비용이 높고 계산량이 많았다

## DeepBind(2015)
기존 방식과 비슷한 방법을 딥러닝(CNN) 통해 수행하여 해당 단백질에 대한 motif 탐색

### 개요
1. High-throughput experiments(고효율 실험) - 데이터 수집 및 가공 단계  
    기존 고전적인 방법(SELEX, RBPs 등)을 한 cycle만 수행하여 데이터 셋 확보  
2. Massively parallel deep learning - 딥러닝 학습 단계  
3. Community needs - 모델을 바탕으로 분석 수행 단계

## 모델구조
Convolve -> RELU 함수, POOLING, FULLY Connectied(DENSE)

## input과 output
input aptamer 후보 물질들,

output은 motif가 있냐 없냐, positive & negative

## 1D convolutions
1차원 텐서 1차원 커널 사용, 1차원 시퀀스에 대해 사용한다.

> RNN은 전체 타임스탬프(순서가 중요) 이건 지엽적인 정보 공간적인 정보를 찾아야해서 CNN이 더 효율적

## motif 스캔
1d convolve 수행 후 Motif scans 데이터로 됨
커널과 필터를 통과한 시퀀스? 여전히 1차원이기 때문에 Relu activation, 통과하면됨

ACGT 4개의 채널이 있다고 본다. 따라서 2차원 데이터로 됨

## 데이터 셋 ALX1
aptamer 후보 물질이 있는 데이터들

### 전처리
* 전부다 positive만 존재하기 때문에 각 데이터를 셔플 시켜 negative도 생성
* ACGT의 4개의 채널을 가지도록 원핫 인코딩
* motif가 맨앞, 맨뒤에 나올 수도 있기 떄문에 m-1 길이의 padding 추가해야함
    * padding의 값은 0.25  
    (AGCT 채널 중 하나만 1이기때문에 padding은 0.25로 평균으로 전부 부여)
    * motif scanner의 크기 m
    * 서열의 길이 s
    * 패딩 추가후 서열 길이 s + 2m -2

## 모델 구조
단일 CNN 레이어
* motif scanner로 사용되는 부분은 첫번째 레이어이므로 1개층 추천
> 수식 표현: $f(s) = net_W(pool(rect_b(conv_M(s))))$

## Convolution
### motif 스캐너의 크기
kernel 사이즈가 motif의 크기보다 조금 더 커야함
* 작으면 motif 못 읽고 넘어감
* 너무 크면 중복해서 motif로 학습해버림
* 가장 중요한 hyperparameter 중 하나

### 계산
* kernel과 dot product(Cross-correlation)
* CNN이라 필터 가중치 공유함
* 계산 후의 벡터값 길이: S + M - 1

## RELU 함수 적용(Rectification)
CNN에서 가장 성능이 좋다. feature가 input을 잘 반영해줘야해서 Relu많이 씀

Elu 계열 함수 종류: 
* Relu: 0보다 작은건 무조건 0
* LeakyRelu: 1이 아니라 0.8 곱하기(정규화 효과 볼 수 있다.)
* Gelu: 0보다 작은건 0이 아니라 작게 Gaussian 값 가지게 함

> 최근 Gelu가 제일 좋다고 함

## Max Pooling
규모 축소를 위해 각 커널마다 가장 큰 값 선택

## 채널 일원화
* 각 채널에 convolve 적용 후 합치기 위해서 필드 별로 덧셈 수행
* 일반적으로 단순히 concatenate 시키지만 여기서는 각 필드 별 데이터가 중요하기 때문에 필드 별로 더한다.

## optimization
결과가 0과 1이니까 cross entropy 써서 가중치 업데이트.  
논문에선 SGD사용

> SGD optimizer 썼는데 사실 별로임, Adam같은거 쓰자