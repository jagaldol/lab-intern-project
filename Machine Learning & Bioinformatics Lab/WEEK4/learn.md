# RNN
## Tensor
데이터 표현의 방식을 tensor라 부른다

* Rank 0 tensor: scalar
* Rank 1 tensor: vector
* Rank 2 tensor: matrix

## Sequence Data
순서가 있는 데이터, 데이터의 순서가 달라지면 정보가 바뀐다.

e.g. RNA Sequence, Time series, Sentence

## Multi-Layer Perceptron
v파라미터 수 

input layer 5개 node

hidden layer 5개 node

\# of parameter = (input node + bias(1개)) x (output Node)
parameter는 가중치(weight)
## RNN(Recurrent Nueural Network)
이전에 학습된 node 정보(hidden state)

MLP에서 hidden state가 추가되었다.

hidden state는 input이나 output이 아닌 hidden layer로 들어간다.

hidden state의 수는 hidden layer의 node 수와 같다.

$h^j_{new} = tanh(\Sigma^n_{i=1}{W_h}_i^jh_i + \Sigma^n_{i=1}W^j_iv_i)$


## LSTM(Long-Short Term Memory)
forget gate, input gate, output gate 3개의 gate가 존재한다.

RNN 에서 좀 더 복잡해짐


## Attention mechanism
RNN 대신 이거 씀 문장에서

## Transformer
가 바로 Attention mechanism이다.

* BERT
* GPT