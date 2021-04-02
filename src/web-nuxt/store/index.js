const initState = () => ({
  messageNuxtServerInit: "init",
  messageVuex: "init"
})

export const state = initState

export const mutations = {
  setMessageNuxtServerInit(state, message) {
    state.messageNuxtServerInit = message
  },
  setMessageVuex(state, message) {
    state.messageVuex = message
  },
  reset(state) {
    Object.assign(state, initState())
  }
}

export const actions = {
  async nuxtServerInit({commit, dispatch}) {
    console.log('nuxtServerInit called');
    const message = 'Hello world from nuxtServerInit()';
    commit("setMessageNuxtServerInit", message)
  },

  async fetchMessage({commit}) {
    const message = 'Hello world from vuex';
    commit('setMessageVuex', message);
  }
}
