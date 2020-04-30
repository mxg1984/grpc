set -e
base_dir=$(cd "$(dirname "$0")";pwd)
cd $base_dir/1.2.11
rm build -rf
mkdir build
pushd build

cmake -DCMAKE_BUILD_TYPE=Release -DCMAKE_INSTALL_PREFIX=/usr/local/ ..
make -j4
make install

popd
rm build -rf

