import gzip
from tqdm import tqdm
from sklearn.model_selection import train_test_split
import numpy as np

# single dataset version
def get_dataset(path):
    dataset = gzip.open(path, "r")
    output = []
    for i, record in tqdm(enumerate(dataset)):
        record = record.decode()
        record = record[:-1]
        record = record.split('\t')
        if i != 0:
            output.append(record)
    output = np.array(output).reshape([-1, 4])

    return encode_onehot(output[:, 2]), np.array(output[:, 3]).flatten()

x, y = get_dataset("./dataset_mini.gz")
train_x, test_x, train_y, test_y = train_test_split(x, y, test_size = 0.33, random_state=112)

del(x, y)

print(train_x.shape)
print(train_y.shape)
